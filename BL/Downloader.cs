using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace BL
{
    public static class Downloader
    {
//        public static async Task Download(string requestString, string localPath)
        public static void Download(string requestString, string localPath)
        {
            HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            //var values = new Dictionary<string, string>
            //  {
            //    { "ssml",       text },
            //    //{ "format",     "lpcm" },
            //    { "lang",       "ru-RU" },
            //    { "voice",      "filipp" },
            //    //{ "emotion",    "evil" },
            //    { "speed",      "1"},
            //    { "folderId",   folderId }
            //  };

            //var content = new FormUrlEncodedContent(values);
            //var response = await client.PostAsync("https://tts.api.cloud.yandex.net/speech/v1/tts:synthesize", content);

            //var response = await client.GetAsync(requestString);
            //var responseBytes = await response.Content.ReadAsByteArrayAsync();
            var response = client.GetAsync(requestString);
            var responseBytes = response.Result.Content.ReadAsStringAsync();
            File.WriteAllText(localPath, responseBytes.Result);

            //File.WriteAllBytes(localPath, responseBytes);
            //var tempfile = Path.GetTempFileName() + ".raw";
            //File.WriteAllBytes(tempfile, responseBytes);
            //Encoder encoder = new Encoder();
            //encoder.Encode(tempfile, outfile);
            //File.Delete(tempfile);
        }
    }
}
