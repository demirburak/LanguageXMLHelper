using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace LanguageXMLHelper.TranslateAPIs
{
    public class TestTranslateAPI : ITranslateAPI
    {
        public string TranslateTrToEn(string trContent)
        {
            return $"English translation is not ready yet.";
            return Test();
        }


        string Test()
        {
            string content = string.Empty;

            using (var client = new HttpClient())
            {
                //var url = "https://libretranslate.com/translate";
                var url = "https://translate.argosopentech.com/translate";
                var jsondata = JsonSerializer.Serialize(new
                {
                    q = "Bugün bir kedi gördüm.",
                    source = "auto",
                    target = "en",
                    format = "text",
                    alternatives = 3,
                    api_key = ""
                });

                StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");

                var reponse = client.PostAsJsonAsync(url, stringContent).Result;
                if (reponse.IsSuccessStatusCode)
                {
                    content = reponse.Content.ReadAsStringAsync().Result;
                }

                return content;
            }
        }
    }
}
