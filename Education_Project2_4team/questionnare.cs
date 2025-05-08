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
        public questionnare()
        {
            InitializeComponent();
        }

        private void btnChooseCourses_Click(object sender, EventArgs e)
        {
            var recommendedCourses = RecommendCourses();
            if (recommendedCourses.Any())
            {
                var form = new CoursesForm(true, recommendedCourses);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Нет подходящих курсов по заданным параметрам.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private List<Courses> RecommendCourses()
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            string selectedForm = comboBoxForm.SelectedItem?.ToString();
            string selectedLevel = comboBoxLevel.SelectedItem?.ToString();
            string selectedDuration = comboBoxDuration.SelectedItem?.ToString();
            double categoryWeight = 0.5;
            double levelWeight = 0.3;
            double formWeight = 0.1;
            double durationWeight = 0.1;

            using (var context = new CoursesContext())
            {
                var allCourses = context.Courses.ToList();

                var scoredCourses = allCourses.Select(course =>
                {
                    double score = 0;

                    if (course.Category == selectedCategory)
                        score += categoryWeight;
                    if (course.EducationalForm == selectedForm)
                        score += formWeight;
                    if (course.LevelOfPreparation == selectedLevel)
                        score += levelWeight;
                    if (course.Duration == selectedDuration)
                        score += durationWeight;

                    return new { Course = course, Score = score };
                });

                return scoredCourses
                    .Where(x => x.Score >= 0.6)
                    .OrderByDescending(x => x.Score)
                    .Select(x => x.Course)
                    .ToList();
            }
        }
    }
}
