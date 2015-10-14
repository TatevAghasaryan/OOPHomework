using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class HtmlSource
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
    }
}
