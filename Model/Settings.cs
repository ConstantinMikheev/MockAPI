using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Основные настройки
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Ключи для загрузки данных из API
        /// </summary>
        public List<string> Keys { get; set; }
        /// <summary>
        /// Каталог для хранения файлов с настройками
        /// </summary>
        public string ServerAPI { get; set; }
        /// <summary>
        /// Общая строка запроса по методам. Если методы имеют похожие строки запроса, можно использовать строку-шаблон.
        /// </summary>
        public string ResourceStringTemplate { get; set; }
        /// <summary>
        /// Порт, на котором слушает Mock-сервер
        /// </summary>
        public int MockServerPort { get; set; } = 8888;

        public Settings()
        {
            Keys = new List<string>();
            ServerAPI = string.Empty;
            ResourceStringTemplate = string.Empty;
        }
    }
}
