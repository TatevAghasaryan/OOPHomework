using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;

namespace SingletonDesignPattern
{
    public sealed class HttpClientInstance : HttpClient
    {
        private static HttpClientInstance _client = new HttpClientInstance();
        private HttpClientInstance()
        {
           
        }
        public static async void GetHtml()
        {
            using(_client)
            {
                try
                {
                    HttpResponseMessage message = await _client.GetAsync("http://www.micarmenia.am/");
                    string result = await message.Content.ReadAsStringAsync();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static HttpClient Instance
        {
            get
            {
                return _client;
            }
        }
    }
}
