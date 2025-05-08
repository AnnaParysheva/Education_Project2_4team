using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education_Project2_4team;

namespace Education_Project2_4team
{
    public partial class CoursesForm : Form
    {
        private readonly bool isCustomer;
        private CoursesContext db;
        private List<Courses> recommendedCourses;
        public CoursesForm(bool isCustomer, List<Courses> recommendedCourses = null)
        {
            InitializeComponent();
            this.isCustomer = isCustomer;
            this.recommendedCourses = recommendedCourses;
            db = new CoursesContext();
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
                btnAddCourse.Enabled = false;
                btnRedact.Enabled = false;
                btnDeleteCourse.Enabled = false;
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
        private void AddCourse_CourseSaved(Courses course)
        {

            var currentDataSource = dataGridViewInformation.DataSource as List<Courses>;
            if (currentDataSource != null)
            {
                currentDataSource.Add(course);
                dataGridViewInformation.DataSource = null;
                dataGridViewInformation.DataSource = currentDataSource;
            }
            else
            {
                DisplayCourses();
            }
        }
        public void DisplayCourses()
        {
            if (!db.Database.CanConnect())
            {
                MessageBox.Show("Нет подключения к базе данных", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new CoursesContext())
            {
                var courses = db.Courses.ToList();
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
        }

        public void DisplayCourseDetails(int IDCourse)
        {
            using (var db = new CoursesContext())
            {
                var courseDetails = db.Courses
                                   .FirstOrDefault(e => e.IDCourses == IDCourse);
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Form = new Profile();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnRedact_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCourse = new AddCourse();
            addCourse.EventSaved += AddCourse_CourseSaved;
            addCourse.Show();
        }
    }
}
