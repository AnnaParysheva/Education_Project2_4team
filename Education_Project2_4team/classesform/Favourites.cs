using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_Project2_4team
{
    /// <summary>
    /// Избранное
    /// </summary>
    public class Favourites
    {
        /// <summary>
        /// Уникальный идентификатор избранного(GUID)
        /// </summary>
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Идентификатор пользователя 
        /// </summary>
        [ForeignKey("Users")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Идентификатор курса 
        /// </summary>
        [ForeignKey("Courses")]
        public Guid IDCourses { get; set; }

        /// <summary>
        /// Навигационное свойство для пользователя
        /// </summary>
        public Users User { get; set; }

        /// <summary>
        /// Навигационное свойство для курса
        /// </summary>
        public Courses Course { get; set; }
    }
}
