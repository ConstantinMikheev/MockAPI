
namespace Models
{
    /// <summary>
    /// Метод API
    /// </summary>
    public class APIMethod
    {
        /// <summary>
        /// Текстовый идентификатор метода
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Загружать данные по методу с сервера API
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Строка получения данных из API
        /// </summary>
        public string ResourceString { get; set; }

        public APIMethod(string name)
        {
            Name = name;
            Enabled = false;
            ResourceString = string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
