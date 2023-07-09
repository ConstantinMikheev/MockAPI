
using System;

namespace Models
{
    /// <summary>
    /// Ключ подключения к API
    /// </summary>
    public class Key
    {
        /// <summary>
        /// Идентификатор ключа (сам ключ)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Срок действия ключа
        /// </summary>
        public DateTime expareDate { get; set; }

        public Key(string id)
        {
            Id = id;
        }
    }
}
