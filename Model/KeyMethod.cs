
namespace Models
{
    /// <summary>
    /// Метод, подключенный к ключу
    /// </summary>
    public class KeyMethod
    {
        /// <summary>
        /// Ключ API
        /// </summary>
        public Key key { get; set; }
        /// <summary>
        /// Метод API
        /// </summary>
        public APIMethod ApiMethod { get; set; }
        /// <summary>
        /// Общее количество запросов на ключе
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// Использованное количество запросов
        /// </summary>
        public int SpentCount { get; set; }

        public KeyMethod(Key key, APIMethod apiMethod)
        {
            this.key = key;
            ApiMethod = apiMethod;
            TotalCount = 0;
            SpentCount = 0;
        }
    }
}
