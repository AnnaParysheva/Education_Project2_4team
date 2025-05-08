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
        public event Action<Courses> EventSaved;
        public AddCourse()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
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
                    using (var db = new CoursesContext())
                    {
                        db.Courses.Add(newCourse);
                        db.SaveChanges();
                    }
                    EventSaved?.Invoke(newCourse);

                    MessageBox.Show("Курс успешно добавлен!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении курса: {ex.Message}",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
