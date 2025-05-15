using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    /// <summary>
    /// Форма для отображение избранного
    /// </summary>
    public partial class FavouritesForm : Form
    {
        /// <summary>
        /// GUID текущего пользователя
        /// </summary>
        private readonly Guid currentUserId;
        /// <summary>
        /// Инициализирует форму избранного для текущего пользователя.
        /// </summary>
        /// <param name="userId"></param>
        public FavouritesForm(Guid userId)
        {
            InitializeComponent();
            currentUserId = userId;
            this.Text = FavouritesForm.label1_Text; 
            label1.Text = FavouritesForm.label1_Text;
            btnRemoveFromFavourites.Text = FavouritesForm.btnRemoveFromFavourites_Text;
            LoadFavourites();
        }
        /// <summary>
        /// Загружает курсы, добавленные пользователем в избранное.
        /// </summary>
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
                ConfigureGridHeaders();
            }
        }
        /// <summary>
        /// Настраивает заголовки и видимость столбцов таблицы избранных курсов.
        /// </summary>
        private void ConfigureGridHeaders()
        {
            if (dataGridViewFavouritesCourses.Columns.Count == 0)
            {
                return;
            }
            dataGridViewFavouritesCourses.Columns["CourseId"].Visible = false;
            dataGridViewFavouritesCourses.Columns["Title"].HeaderText = CoursesForm.ColumnTitle_Name;
            dataGridViewFavouritesCourses.Columns["Duration"].HeaderText = CoursesForm.ColumnTitle_Duration;
            dataGridViewFavouritesCourses.Columns["Category"].HeaderText = CoursesForm.ColumnTitle_Category;
            dataGridViewFavouritesCourses.Columns["Description"].HeaderText = CoursesForm.ColumnTitle_Description;
            dataGridViewFavouritesCourses.Columns["Level"].HeaderText = CoursesForm.ColumnTitle_Level;
            dataGridViewFavouritesCourses.Columns["EducationForm"].HeaderText = CoursesForm.ColumnTitle_EducationalForm;
        }
        /// <summary>
        /// Удаляет выбранный курс из избранного.
        /// </summary>
        private void btnRemoveFromFavourites_Click(object sender, EventArgs e)
        {
            if (dataGridViewFavouritesCourses.CurrentRow == null)
            {
                MessageBox.Show(
                    FavouritesForm.Warning_SelectCourseForRemoval,
                    FavouritesForm.Title_Warning,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var courseId = (Guid)dataGridViewFavouritesCourses.CurrentRow.Cells["CourseId"].Value;
            var courseTitle = dataGridViewFavouritesCourses.CurrentRow.Cells["Title"].Value.ToString();

            using (var db = new FavouritesContext())
            {
                var favToRemove = db.Favourites
                    .FirstOrDefault(f => f.UserId == currentUserId && f.IDCourses == courseId);
                if (favToRemove != null)
                {
                    db.Favourites.Remove(favToRemove);
                    db.SaveChanges();
                    MessageBox.Show(
                        string.Format(FavouritesForm.Message_CourseRemoved, courseTitle),
                        FavouritesForm.Title_Success,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadFavourites();
                }
                else
                {
                    MessageBox.Show(
                        FavouritesForm.Message_FavouriteNotFound,
                        FavouritesForm.Title_Error,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
