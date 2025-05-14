using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Education_Project2_4team
{
    /// <summary>
    /// Учебный курс 
    /// </summary>
    public class Courses
    {
        /// <summary>
        /// Уникальный идентификатор курса (GUID)
        /// </summary>
        [Key]
        public Guid IDCourses { get; set; } = Guid.NewGuid();
        /// <summary>
        /// Название курса
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Продолжительность курса
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// Категория курса
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Описание содержания курса
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Уровень подготовки 
        /// </summary>
        public string LevelOfPreparation { get; set; }
        /// <summary>
        /// Форма обучения
        /// </summary>
        public string EducationalForm { get; set; }
        /// <summary>
        /// Список избранного
        /// </summary>
        public List<Favourites> Favourites { get; set; } = new List<Favourites>();
    }
}

