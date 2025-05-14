using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    /// <summary>
    /// Форма отображения и управления курсами
    /// </summary>
    public partial class CoursesForm : Form
    {
        /// <summary>
        /// идентификатор текущего пользователя
        /// </summary>
        private readonly Guid? userId;
        /// <summary>
        /// Флаг, определяющий роль пользователя в системе
        /// </summary>
        private readonly bool isCustomer;
        /// <summary>
        /// Контекст базы данных для работы с курсами
        /// </summary>
        private readonly CoursesContext db;
        /// <summary>
        /// Список рекомендованных курсов для текущего пользователя
        /// </summary>
        private readonly List<Courses> recommendedCourses;
        /// <summary>
        /// Конструктор формы курсов
        /// </summary>
        public CoursesForm(bool isCustomer, List<Courses> recommendedCourses = null, Guid? userId = null)
        {
            InitializeComponent();
            this.isCustomer = isCustomer;
            this.recommendedCourses = recommendedCourses;
            this.userId = userId;
            db = new CoursesContext();
            InitializeDatabase();
            SetUpForm();
        }
        private void InitializeDatabase()
        {
            db.Database.EnsureCreated();
            if (recommendedCourses != null)
            {
                DisplayCourses(recommendedCourses);
            }
            else
            {
                DisplayCourses(db.Courses.ToList());
            }
        }

        private void SetUpForm()
        {
            btnAddCourse.Visible = !isCustomer;
            btnRedact.Visible = !isCustomer;
            btnDeleteCourse.Visible = !isCustomer;
            btnOpenFavourites.Visible = isCustomer;
            btnAddToFavourites.Visible = isCustomer;
        }
        /// <summary>
        /// Отображает список курсов в таблице
        /// </summary>
        public void DisplayCourses(List<Courses> courses)
        {
            if (courses == null)
            {
                return;
            }
            dataGridViewInformation.AutoGenerateColumns = false;
            dataGridViewInformation.Columns.Clear();
            dataGridViewInformation.Columns.Add(CreateTextColumn("Title", "Название курса", 200));
            dataGridViewInformation.Columns.Add(CreateTextColumn("Description", "Описание", 150));
            dataGridViewInformation.Columns.Add(CreateTextColumn("Category", "Категория", 150));
            dataGridViewInformation.Columns.Add(CreateTextColumn("Duration", "Продолжительность", 120));
            dataGridViewInformation.Columns.Add(CreateTextColumn("EducationalForm", "Форма обучения", 120));
            dataGridViewInformation.Columns.Add(CreateTextColumn("LevelOfPreparation", "Уровень подготовки", 150));
            dataGridViewInformation.DataSource = courses;
            dataGridViewInformation.RowHeadersVisible = false;
        }
        private DataGridViewTextBoxColumn CreateTextColumn(string property, string header, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = property,
                HeaderText = header,
                Width = width
            };
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewInformation.CurrentRow?.DataBoundItem is Courses selectedCourse))
            {
                MessageBox.Show("Пожалуйста, выберите курс для удаления.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show($"Вы уверены, что хотите удалить курс \"{selectedCourse.Title}\"?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var courseToDelete = db.Courses.Find(selectedCourse.IDCourses);
                if (courseToDelete != null)
                {
                    db.Courses.Remove(courseToDelete);
                    db.SaveChanges();
                    MessageBox.Show("Курс удалён.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCourses(db.Courses.ToList());
                }
                else
                {
                    MessageBox.Show("Курс не найден в базе данных.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnRedact_Click(object sender, EventArgs e)
        {
            if (dataGridViewInformation.CurrentRow?.DataBoundItem is Courses selectedCourse)
            {
                var editCourseForm = new AddCourse(selectedCourse);
                editCourseForm.EventSaved += (Courses newCourse) => DisplayCourses(db.Courses.ToList());
                editCourseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите курс для редактирования.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCourse = new AddCourse();
            addCourse.EventSaved += (Courses newCourse) => DisplayCourses(db.Courses.ToList());
            addCourse.ShowDialog();
        }

        private void btnOpenFavourites_Click(object sender, EventArgs e)
        {
            if (userId.HasValue)
            {
                var favouritesForm = new FavouritesForm(userId.Value);
                favouritesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Только пользователи могут просматривать избранное.", "Доступ запрещен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddToFavourites_Click(object sender, EventArgs e)
        {
            if (!userId.HasValue)
            {
                MessageBox.Show("Только авторизованные пользователи могут добавлять в избранное.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(dataGridViewInformation.CurrentRow?.DataBoundItem is Courses selectedCourse))
            {
                MessageBox.Show("Пожалуйста, выберите курс для добавления в избранное.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var favDb = new FavouritesContext())
            {
                var alreadyExists = favDb.Favourites
                    .Any(f => f.UserId == userId.Value && f.IDCourses == selectedCourse.IDCourses);

                if (alreadyExists)
                {
                    MessageBox.Show("Этот курс уже добавлен в избранное.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    favDb.Favourites.Add(new Favourites
                    {
                        UserId = userId.Value,
                        IDCourses = selectedCourse.IDCourses
                    });
                    favDb.SaveChanges();
                    MessageBox.Show("Курс добавлен в избранное!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var selectedCategory = comboBoxFilter.SelectedItem?.ToString();
            List<Courses> courses;
            if (selectedCategory == "Все категории")
            {
                courses = db.Courses.ToList();
            }
            else
            {
                courses = db.Courses.Where(c => c.Category == selectedCategory).ToList();
            }

            if (!courses.Any())
            {
                MessageBox.Show("Курсы с выбранной категорией не найдены.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DisplayCourses(courses);
        }
    }
}
