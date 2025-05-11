using Education_Project2_4team;
using Microsoft.EntityFrameworkCore;
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
    public partial class FavouritesForm : Form
    {
        private int currentUserId;
        public FavouritesForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadFavourites();
        }
        private void LoadFavourites()
        {
            using (var db = new FavouritesContext())
            {
                var favourites = db.Favourites
                    .Include(f => f.Course)
                    .Where(f => f.UserId == currentUserId && f.Course != null)
                    .Select(f => new
                    {
                        CourseId = f.Course.IDCourses,
                        Title = f.Course.Title,
                        Duration = f.Course.Duration,
                        Category = f.Course.Category,
                        Description = f.Course.Description,
                        Level = f.Course.LevelOfPreparation,
                        EducationForm = f.Course.EducationalForm
                    })
                    .ToList();

                dataGridViewFavouritesCourses.DataSource = favourites;
                if (dataGridViewFavouritesCourses.Columns.Count > 0)
                {
                    dataGridViewFavouritesCourses.Columns["CourseId"].Visible = false;
                    dataGridViewFavouritesCourses.Columns["Title"].HeaderText = "Название";
                    dataGridViewFavouritesCourses.Columns["Duration"].HeaderText = "Длительность";
                    dataGridViewFavouritesCourses.Columns["Category"].HeaderText = "Категория";
                    dataGridViewFavouritesCourses.Columns["Description"].HeaderText = "Описание";
                    dataGridViewFavouritesCourses.Columns["Level"].HeaderText = "Уровень подготовки";
                    dataGridViewFavouritesCourses.Columns["EducationForm"].HeaderText = "Форма обучения";
                }
            }
        }

        private void btnRemoveFromFavourites_Click(object sender, EventArgs e)
        {
            if (dataGridViewFavouritesCourses.CurrentRow == null)
            {
                MessageBox.Show("Выберите курс для удаления из избранного.", "Предупреждение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int courseId = (int)dataGridViewFavouritesCourses.CurrentRow.Cells["CourseId"].Value;
            string courseTitle = dataGridViewFavouritesCourses.CurrentRow.Cells["Title"].Value.ToString();
            using (var db = new FavouritesContext())
            {
                var favToRemove = db.Favourites
                    .FirstOrDefault(f => f.UserId == currentUserId &&
                               f.IDCourses == courseId);

                if (favToRemove != null)
                {
                    db.Favourites.Remove(favToRemove);
                    db.SaveChanges();
                    MessageBox.Show($"Курс '{courseTitle}' удален из избранного.", "Успешно",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFavourites();
                }
                else
                {
                    MessageBox.Show("Не удалось найти запись в избранном.", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
