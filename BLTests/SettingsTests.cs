using System;
using System.IO;
using System.Text.Json;
using NUnit.Framework;
using BL;

namespace BLTests
{
    [TestFixture]
    public class SettingsTests
    {
        [Test]
        public void SettingsSerialization()
        {
            var serverAPI = "http://qwe";
            var port = 1234;
            var template = "/api/qwe";
            var key1 = "100";
            var key2 = "200";

            var path = Path.Combine(Path.GetTempPath(), "Settings.json");
            File.Delete(path);

            var data = new APIData(Path.GetTempPath());
            data.settings.ServerAPI = serverAPI;
            data.settings.MockServerPort = port;
            data.settings.ResourceStringTemplate = template;
            data.settings.Keys.Add(key1);
            data.settings.Keys.Add(key2);

            data.SaveSettings();

            if (!File.Exists(path))
                throw new Exception("Не удалось сериализовать Settings");

            var data2 = new APIData(Path.GetTempPath());
            var curSettings = data2.settings;
            Assert.AreEqual(serverAPI, curSettings.ServerAPI);
            Assert.AreEqual(port, curSettings.MockServerPort);
            Assert.AreEqual(template, curSettings.ResourceStringTemplate);
            Assert.AreEqual(key1, curSettings.Keys[0]);
            Assert.AreEqual(key2, curSettings.Keys[1]);

            File.Delete(path);
        }
    }
}
