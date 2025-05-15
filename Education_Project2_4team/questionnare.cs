using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team
{
        public partial class questionnare : Form
        {
            private int userId;

            public questionnare(int userId)
            {
                InitializeComponent();
                this.userId = userId;
            }

            private void btnChooseCourses_Click(object sender, EventArgs e)
            {
                string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
                string selectedForm = comboBoxForm.SelectedItem?.ToString();
                string selectedLevel = comboBoxLevel.SelectedItem?.ToString();
                string selectedDuration = comboBoxDuration.SelectedItem?.ToString();

                var usingClass = new CoursesFormUsing();
                var recommendedCourses = usingClass.RecommendCourses(selectedCategory, selectedForm, selectedLevel, selectedDuration);

                if (recommendedCourses.Any())
                {
                    var form = new CoursesForm(true, recommendedCourses, userId);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Нет подходящих курсов по заданным параметрам.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
}
