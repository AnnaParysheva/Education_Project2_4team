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
            var recommendedCourses = RecommendCourses();
            if (recommendedCourses.Any())
            {
                var form = new CoursesForm(true, recommendedCourses,userId);
                this.Hide();
                form.ShowDialog();
                this.Show();
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
            using (var favDb = new FavouritesContext())
            using (var context = new CoursesContext())
            {
                bool hasFavorites = favDb.Favourites.Any(f => f.UserId == userId);
                if (!hasFavorites)
                {
                    if (string.IsNullOrEmpty(selectedCategory) ||
                        string.IsNullOrEmpty(selectedForm) ||
                        string.IsNullOrEmpty(selectedLevel) ||
                        string.IsNullOrEmpty(selectedDuration))
                    {
                        MessageBox.Show("При отсутствии избранных курсов необходимо заполнить все поля анкеты",
                                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return new List<Courses>();
                    }
                }
                // для текущего выбора
                double currentCategoryWeight = 1.0;
                double currentLevelWeight = 0.6;
                double currentFormWeight = 0.3;
                double currentDurationWeight = 0.2;

                // для избранного
                double favoriteCategoryWeight = 0.6;
                double favoriteLevelWeight = 0.05;
                double favoriteFormWeight = 0.05;
                double favoriteDurationWeight = 0.05;

                var allCourses = context.Courses.ToList();
                var favoriteCourseIds = favDb.Favourites
                                    .Where(f => f.UserId == userId)
                                    .Select(f => f.IDCourses)
                                    .ToList();
                Dictionary<string, double> favoritePreferences = new Dictionary<string, double>();
                if (favoriteCourseIds.Any())
                {
                    var favoriteCoursesData = context.Courses
                                        .Where(c => favoriteCourseIds.Contains(c.IDCourses))
                                        .ToList();

                    foreach (var course in favoriteCoursesData)
                    {
                        if (favoritePreferences.ContainsKey(course.Category))
                            favoritePreferences[course.Category] += favoriteCategoryWeight;
                        else
                            favoritePreferences[course.Category] = favoriteCategoryWeight;
                        if (favoritePreferences.ContainsKey(course.LevelOfPreparation))
                            favoritePreferences[course.LevelOfPreparation] += favoriteLevelWeight;
                        else
                            favoritePreferences[course.LevelOfPreparation] = favoriteLevelWeight;
                        if (favoritePreferences.ContainsKey(course.EducationalForm))
                            favoritePreferences[course.EducationalForm] += favoriteFormWeight;
                        else
                            favoritePreferences[course.EducationalForm] = favoriteFormWeight;
                        if (favoritePreferences.ContainsKey(course.Duration))
                            favoritePreferences[course.Duration] += favoriteDurationWeight;
                        else
                            favoritePreferences[course.Duration] = favoriteDurationWeight;
                    }
                }
                var scoredCourses = allCourses.Select(course =>
                {
                    double score = 0;
                    if (!string.IsNullOrEmpty(selectedCategory) && course.Category == selectedCategory)
                        score += currentCategoryWeight;
                    if (!string.IsNullOrEmpty(selectedForm) && course.EducationalForm == selectedForm)
                        score += currentFormWeight;
                    if (!string.IsNullOrEmpty(selectedLevel) && course.LevelOfPreparation == selectedLevel)
                        score += currentLevelWeight;
                    if (!string.IsNullOrEmpty(selectedDuration) && course.Duration == selectedDuration)
                        score += currentDurationWeight;
                    if (favoritePreferences.Count > 0)
                    {
                        if (favoritePreferences.TryGetValue(course.Category, out double categoryValue))
                            score += categoryValue;
                        if (favoritePreferences.TryGetValue(course.LevelOfPreparation, out double levelValue))
                            score += levelValue;
                        if (favoritePreferences.TryGetValue(course.EducationalForm, out double formValue))
                            score += formValue;
                        if (favoritePreferences.TryGetValue(course.Duration, out double durationValue))
                            score += durationValue;
                    }
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
