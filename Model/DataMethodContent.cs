
namespace Model
{
    /// <summary>
    /// Данные, полученные по методу
    /// </summary>
    public class DataMethodContent
    {
        /// <summary>
        /// Запрашиваемые данные
        /// </summary>
        public string RequestData { get; set; }
        /// <summary>
        /// Метод API
        /// </summary>
        public APIMethod ApiMethod { get; set; }
        /// <summary>
        /// Путь к содержимому в текстовом виде
        /// </summary>
        public string ContentPath { get; set; }

        public DataMethodContent(string requestData, APIMethod apiMethod)
        {
            RequestData = requestData;
            ApiMethod = apiMethod;
            ContentPath = string.Empty;
        }

        public DataMethodContent(string requestData, APIMethod apiMethod, string contentPath)
        {
            RequestData = requestData;
            ApiMethod = apiMethod;
            ContentPath = contentPath;
        }
    }
}
