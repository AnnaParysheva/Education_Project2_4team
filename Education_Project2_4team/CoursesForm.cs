using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    public partial class CoursesForm : Form
    {
        private int? userId;
        private readonly bool isCustomer;
        private CoursesContext db;
        private List<Courses> recommendedCourses;
        private CoursesFormUsing coursesFormUsing;

        public CoursesForm(bool isCustomer, List<Courses> recommendedCourses = null, int? userId = null)
        {
            InitializeComponent();
            this.isCustomer = isCustomer;
            this.recommendedCourses = recommendedCourses;
            this.userId = userId;
            db = new CoursesContext();
            coursesFormUsing = new CoursesFormUsing();
            InitializeDatabase();
            SetUpForm();
        }

        private void InitializeDatabase()
        {
            db.Database.EnsureCreated();

            if (recommendedCourses != null)
                DisplayRecommendedCourses(recommendedCourses);
            else
                DisplayCourses();
        }

        private void SetUpForm()
        {
            if (isCustomer)
            {
                btnAddCourse.Visible = false;
                btnRedact.Visible = false;
                btnDeleteCourse.Visible = false;
                btnFilter.Visible = false;
                comboBoxFilter.Visible = false;
                btnOpenFavourites.Visible = true;
                btnAddToFavourites.Visible = true;
            }
            else
            {
                btnAddCourse.Visible = true;
                btnRedact.Visible = true;
                btnDeleteCourse.Visible = true;
                btnFilter.Visible = true;
                comboBoxFilter.Visible = true;
                btnOpenFavourites.Visible = false;
                btnAddToFavourites.Visible = false;
            }
        }

        public void DisplayRecommendedCourses(List<Courses> courses)
        {
            dataGridViewInformation.AutoGenerateColumns = false;
            dataGridViewInformation.Columns.Clear();

            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Title",
                HeaderText = "Название курса",
                Width = 200
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = "Описание",
                Width = 150
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Category",
                HeaderText = "Категория",
                Width = 150
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Duration",
                HeaderText = "Продолжительность",
                Width = 120
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EducationalForm",
                HeaderText = "Форма обучения",
                Width = 120
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "LevelOfPreparation",
                HeaderText = "Уровень подготовки",
                Width = 150
            });
            dataGridViewInformation.DataSource = courses;
            dataGridViewInformation.RowHeadersVisible = false;
        }

        public void DisplayCourses()
        {
            if (!db.Database.CanConnect())
            {
                MessageBox.Show("Нет подключения к базе данных", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var courses = coursesFormUsing.GetAllCourses();

            dataGridViewInformation.AutoGenerateColumns = false;
            dataGridViewInformation.Columns.Clear();
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Title",
                HeaderText = "Название курса",
                Width = 200
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = "Описание",
                Width = 150
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Category",
                HeaderText = "Категория",
                Width = 150
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Duration",
                HeaderText = "Продолжительность",
                Width = 120
            });
            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EducationalForm",
                HeaderText = "Форма обучения",
                Width = 120
            });

            dataGridViewInformation.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "LevelOfPreparation",
                HeaderText = "Уровень подготовки",
                Width = 150
            });
            dataGridViewInformation.DataSource = courses;
            dataGridViewInformation.RowHeadersVisible = false;
        }

        public void DisplayCourseDetails(int IDCourse)
        {
            var courseDetails = coursesFormUsing.GetCourseDetails(IDCourse);
            if (courseDetails != null)
            {
                var table = new DataTable();

                table.Columns.Add("Название", typeof(string));
                table.Columns.Add("Продолжительность", typeof(string));
                table.Columns.Add("Категория", typeof(string));
                table.Columns.Add("Описание", typeof(string));
                table.Columns.Add("Уровень подготовки", typeof(string));
                table.Columns.Add("Форма обучения", typeof(string));
                var row = table.NewRow();
                row["Название"] = courseDetails.Title;
                row["Продолжительность"] = courseDetails.Duration;
                row["Категория"] = courseDetails.Category;
                row["Описание"] = courseDetails.Description;
                row["Уровень подготовки"] = courseDetails.LevelOfPreparation;
                row["Форма обучения"] = courseDetails.EducationalForm;
                table.Rows.Add(row);
                dataGridViewInformation.DataSource = table;
                dataGridViewInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewInformation.RowHeadersVisible = false;
                dataGridViewInformation.Columns["Описание"].DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;
                dataGridViewInformation.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                dataGridViewInformation.DataSource = null;
            }
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
                                         "Подтверждение удаления",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool deleted = coursesFormUsing.DeleteCourse(selectedCourse.IDCourses);
                if (deleted)
                {
                    MessageBox.Show("Курс удалён.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCourses();
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
                editCourseForm.EventSaved += (updatedCourse) => DisplayCourses();
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
            addCourse.EventSaved += (Courses newCourse) => DisplayCourses();
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

            bool added = coursesFormUsing.AddToFavourites(userId.Value, selectedCourse.IDCourses);
            if (added)
            {
                MessageBox.Show("Курс добавлен в избранное!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Этот курс уже добавлен в избранное.", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxFilter.SelectedItem?.ToString();
            var courses = coursesFormUsing.FilterByCategory(selectedCategory ?? "Все категории");

            if (courses.Count == 0)
            {
                MessageBox.Show("Курсы с выбранной категорией не найдены.", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = courses;
        }
    }

}

