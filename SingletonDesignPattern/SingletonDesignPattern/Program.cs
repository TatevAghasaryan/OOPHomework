using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        public static async void GetHtml()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage message = await client.GetAsync("http://www.micarmenia.am/");
                    string result = await message.Content.ReadAsStringAsync();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {

            HttpClientInstance c1 = HttpClientInstance.Instance;
            HttpClientInstance c2 = HttpClientInstance.Instance;

            Console.WriteLine(object.ReferenceEquals(c1,c2));
            
            Console.ReadKey();
        }
    }
}
