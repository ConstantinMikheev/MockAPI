
namespace Model
{
    /// <summary>
    /// Свойства методов API, подключенных к ключу
    /// </summary>
    public class KeyMethod
    {
        /// <summary>
        /// Ключ API
        /// </summary>
        public string key { get; }
        /// <summary>
        /// Метод API
        /// </summary>
        public string ApiMethod { get; }
        /// <summary>
        /// Общее количество запросов на ключе
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// Использованное количество запросов
        /// </summary>
        public int SpentCount { get; set; }

        public KeyMethod(string key, string apiMethod)
        {
            this.key = key;
            ApiMethod = apiMethod;
            TotalCount = 0;
            SpentCount = 0;
        }
    }
}
