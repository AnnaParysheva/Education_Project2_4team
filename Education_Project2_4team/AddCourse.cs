using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    public partial class AddCourse : Form
    {
        private readonly Courses editingCourse;

        public event Action<Courses> EventSaved;
        public AddCourse()
        {
            InitializeComponent();
        }
        public AddCourse(Courses courseToEdit) : this()
        {
            if (courseToEdit != null)
            {
                editingCourse = courseToEdit;
                FillFormForEdit(courseToEdit);
            }
        }
        private void FillFormForEdit(Courses course)
        {
            txtTitle.Text = course.Title;
            comboBoxDuration.SelectedItem = course.Duration;
            comboBoxCategory.SelectedItem = course.Category;
            txtDescription.Text = course.Description;
            comboBoxLevelOfPreparation.SelectedItem = course.LevelOfPreparation;
            comboBoxEducationForm.SelectedItem = course.EducationalForm;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new CoursesContext())
                {
                    if (editingCourse == null)
                    {
                        var newCourse = new Courses
                        {
                            Title = txtTitle.Text,
                            Duration = comboBoxDuration.SelectedItem.ToString(),
                            Category = comboBoxCategory.SelectedItem.ToString(),
                            Description = txtDescription.Text,
                            LevelOfPreparation = comboBoxLevelOfPreparation.SelectedItem.ToString(),
                            EducationalForm = comboBoxEducationForm.SelectedItem.ToString()
                        };

                        db.Courses.Add(newCourse);
                        db.SaveChanges();
                        EventSaved?.Invoke(newCourse);
                        MessageBox.Show("Курс успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var course = db.Courses.FirstOrDefault(c => c.IDCourses == editingCourse.IDCourses);
                        if (course != null)
                        {
                            course.Title = txtTitle.Text;
                            course.Duration = comboBoxDuration.SelectedItem.ToString();
                            course.Category = comboBoxCategory.SelectedItem.ToString();
                            course.Description = txtDescription.Text;
                            course.LevelOfPreparation = comboBoxLevelOfPreparation.SelectedItem.ToString();
                            course.EducationalForm = comboBoxEducationForm.SelectedItem.ToString();
                            db.SaveChanges();
                            EventSaved?.Invoke(course);
                            MessageBox.Show("Курс успешно обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Курс не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении курса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название курса", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxDuration.SelectedItem == null)
            {
                MessageBox.Show("Выберете продолжительность курса",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберете категорию",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Введите описание курса",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxLevelOfPreparation.SelectedItem == null)
            {
                MessageBox.Show("Выберете уровень подготовки",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxEducationForm.SelectedItem == null)
            {
                MessageBox.Show("Выберете продолжительность курса",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
