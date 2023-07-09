
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
        /// Содержимое в текстовом виде
        /// </summary>
        public string Content { get; set; }

        public DataMethodContent(string requestData, APIMethod apiMethod)
        {
            RequestData = requestData;
            ApiMethod = apiMethod;
            Content = string.Empty;
        }
    }
}
