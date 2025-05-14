using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Education_Project2_4team
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Уникальный идентификатор пользователя (GUID)
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Логин 
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Список курсов, добавленных пользователем в избранное
        /// </summary>
        public List<Favourites> Favourites { get; set; } = new List<Favourites>();
    }
}
