using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using BL;
using Model;

namespace BLTests
{
    [TestFixture]
    public class DataContentTests
    {
        [Test]
        public void DataContentCreation()
        {
            var methodName1 = "method1";
            var methodName2 = "method2";
            var methodName3 = "method3";
            var methodName4 = "method4";
            var data = new APIData(@"w:\");
            data.AddAPIMethod(methodName1);
            data.AddAPIMethod(methodName2);
            data.AddAPIMethod(methodName3);

            var requestString1 = "1234";
            var requestString2 = "12345";
            Assert.IsNull(data.GetContent(requestString1));
            data.AddContentRequestString(requestString1);
            data.AddContentRequestString(requestString2);
            var dataMethods = data.GetContent(requestString1);
            Assert.IsNotNull(dataMethods);

            try
            {
                data.AddContentRequestString(requestString1);
                throw new Exception("Не прошел тест на проверку дублей контента");
            } catch (Exception ex)
            {
                Assert.AreEqual($"Строка запроса контента {requestString1} уже существует.", ex.Message);
            }

            dataMethods = data.GetContent(requestString1);
            foreach (var method in dataMethods)
            {
                Assert.AreEqual(requestString1, method.RequestData);
                var methodName = method.ApiMethod.Name;
                if (!(methodName == methodName1 || methodName == methodName2 || methodName == methodName3))
                    throw new Exception("У контента НЕ найдены методы");
            }

            data.AddAPIMethod(methodName4);
            dataMethods = data.GetContent(requestString1);
            bool found = false;
            foreach (var method in dataMethods)
            {
                Assert.AreEqual(requestString1, method.RequestData);
                var methodName = method.ApiMethod.Name;
                if (methodName == methodName4)
                    found = true;
            }
            if (!found)
                throw new Exception($"У контента НЕ найден метод {methodName4}");

            data.RemoveAPIMethod(methodName4);
            dataMethods = data.GetContent(requestString1);
            found = false;
            foreach (var method in dataMethods)
            {
                Assert.AreEqual(requestString1, method.RequestData);
                var methodName = method.ApiMethod.Name;
                if (methodName == methodName4)
                    found = true;
            }
            if (found)
                throw new Exception($"У контента НАЙДЕН метод {methodName4}");

            data.RemoveContentRequestString(requestString2);
            Assert.IsNull(data.GetContent(requestString2), "Не удалось удалить строку запроса контента");
        }

        [Test]
        public void DataContentSerialization()
        {
            var path = Path.Combine(Path.GetTempPath(), "DataContentSettings.json");
            var path2 = Path.Combine(Path.GetTempPath(), "APIMethods.json");
            File.Delete(path);
            File.Delete(path2);
            var methodName1 = "method1";
            var methodName2 = "method2";
            var methodName3 = "method3";
            var data = new APIData(Path.GetTempPath());
            data.AddAPIMethod(methodName1);
            data.AddAPIMethod(methodName2);
            data.AddAPIMethod(methodName3);

            var requestString1 = "1234";
            var requestString2 = "12345";
            data.AddContentRequestString(requestString1);
            data.AddContentRequestString(requestString2);

            data.SaveAPIMethods();
            data.SaveDataContentSettings();

            if (!File.Exists(path))
                throw new Exception("Не удалось сериализовать DataContentSettings");

            var data2 = new APIData(Path.GetTempPath());

            var dataMethods = data2.GetContent(requestString1);
            foreach (var method in dataMethods)
            {
                Assert.AreEqual(requestString1, method.RequestData);
                var methodName = method.ApiMethod.Name;
                if (!(methodName == methodName1 || methodName == methodName2 || methodName == methodName3))
                    throw new Exception("У контента НЕ найдены методы");
            }

            File.Delete(path);
            File.Delete(path2);
        }
    }
}
