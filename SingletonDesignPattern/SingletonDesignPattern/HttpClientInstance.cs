﻿using System;
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
        private static HttpClientInstance _client;
        private HttpClientInstance() 
        {
            
        }       
        static HttpClientInstance()
        {
            _client = new HttpClientInstance();
            GetHtml();
        }

        public static HttpClientInstance Instance
        {
            get
            {
                return _client;
            }
        }

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
