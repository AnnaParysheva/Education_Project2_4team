using System;
using System.Linq;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    /// <summary>
    /// Форма для добавления или редактирования курса
    /// </summary>
    public partial class AddCourse : Form
    {
        /// <summary>
        /// Курс, который редактируется
        /// </summary>
        private readonly Courses editingCourse;
        /// <summary>
        /// Событие, возникающее при успешном сохранении курса
        /// </summary>
        public event Action<Courses> EventSaved;
        /// <summary>
        /// Конструктор для создания нового курса
        /// </summary>
        public AddCourse()
        {
            InitializeComponent();
            this.Text = AddCourseResources.FormTitleAddCourse;
            label7.Text = AddCourseResources.LabelMainHeader;
            label1.Text = AddCourseResources.LabelTitle;
            label10.Text = AddCourseResources.LabelDescription;
            btnSaveNewCourse.Text = AddCourseResources.ButtonSaveText;
            comboBoxDuration.Text = AddCourseResources.ComboBoxDurationPrompt;
            comboBoxCategory.Text = AddCourseResources.ComboBoxCategoryPrompt;
            comboBoxLevelOfPreparation.Text = AddCourseResources.ComboBoxLevelPrompt;
            comboBoxEducationForm.Text = AddCourseResources.ComboBoxFormPrompt;
            comboBoxCategory.Items.AddRange(AddCourseResources.ComboBoxCategoryItems.Split(';'));
            comboBoxDuration.Items.AddRange(AddCourseResources.ComboBoxDurationItems.Split(';'));
            comboBoxEducationForm.Items.AddRange(AddCourseResources.ComboBoxFormItems.Split(';'));
            comboBoxLevelOfPreparation.Items.AddRange(AddCourseResources.ComboBoxLevelItems.Split(';'));
        }
        /// <summary>
        /// Конструктор для редактирования существующего курса
        /// </summary>
        /// <param name="courseToEdit"></param>
        public AddCourse(Courses courseToEdit) : this()
        {
            if (courseToEdit != null)
            {
                editingCourse = courseToEdit;
                FillFormForEdit(courseToEdit);
            }
        }
        /// <summary>
        /// Заполняет форму данными редактируемого курса
        /// </summary>
        /// <param name="course"></param>
        private void FillFormForEdit(Courses course)
        {
            txtTitle.Text = course.Title;
            comboBoxDuration.SelectedItem = course.Duration;
            comboBoxCategory.SelectedItem = course.Category;
            txtDescription.Text = course.Description;
            comboBoxLevelOfPreparation.SelectedItem = course.LevelOfPreparation;
            comboBoxEducationForm.SelectedItem = course.EducationalForm;
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            try
            {
                using (var db = new CoursesContext())
                {
                    if (editingCourse == null)
                    {
                        var newCourse = CreateCourseFromForm();
                        db.Courses.Add(newCourse);
                        db.SaveChanges();
                        EventSaved?.Invoke(newCourse);
                        MessageBox.Show(
                            AddCourseResources.AddCourse_SaveSuccess_Add,
                            AddCourseResources.FormTitleAddCourse,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        var course = db.Courses.FirstOrDefault(c => c.IDCourses == editingCourse.IDCourses);
                        if (course != null)
                        {
                            UpdateCourseFromForm(course);
                            db.SaveChanges();
                            EventSaved?.Invoke(course);
                            MessageBox.Show(
                                AddCourseResources.AddCourse_SaveSuccess_Update,
                                AddCourseResources.FormTitleAddCourse,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                AddCourseResources.AddCourse_CourseNotFound,
                                AddCourseResources.FormTitleAddCourse,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(AddCourseResources.AddCourse_SaveError, ex.Message),
                    AddCourseResources.FormTitleAddCourse,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        /// <summary>
        /// Создаёт объект курса на основе данных формы
        /// </summary>
        private Courses CreateCourseFromForm()
        {
            return new Courses
            {
                Title = txtTitle.Text,
                Duration = comboBoxDuration.SelectedItem.ToString(),
                Category = comboBoxCategory.SelectedItem.ToString(),
                Description = txtDescription.Text,
                LevelOfPreparation = comboBoxLevelOfPreparation.SelectedItem.ToString(),
                EducationalForm = comboBoxEducationForm.SelectedItem.ToString()
            };
        }
        /// <summary>
        /// Обновляет переданный курс значениями из формы
        /// </summary>
        /// <param name="course">Курс для обновления</param>
        private void UpdateCourseFromForm(Courses course)
        {
            course.Title = txtTitle.Text;
            course.Duration = comboBoxDuration.SelectedItem.ToString();
            course.Category = comboBoxCategory.SelectedItem.ToString();
            course.Description = txtDescription.Text;
            course.LevelOfPreparation = comboBoxLevelOfPreparation.SelectedItem.ToString();
            course.EducationalForm = comboBoxEducationForm.SelectedItem.ToString();
        }
        /// <summary>
        /// Проверяет корректность заполнения формы
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show(AddCourseResources.AddCourse_TitleRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxDuration.SelectedItem == null)
            {
                MessageBox.Show(AddCourseResources.AddCourse_DurationRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show(AddCourseResources.AddCourse_CategoryRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show(AddCourseResources.AddCourse_DescriptionRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxLevelOfPreparation.SelectedItem == null)
            {
                MessageBox.Show(AddCourseResources.AddCourse_LevelRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxEducationForm.SelectedItem == null)
            {
                MessageBox.Show(AddCourseResources.AddCourse_EduFormRequired,
                              AddCourseResources.FormTitleAddCourse,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}