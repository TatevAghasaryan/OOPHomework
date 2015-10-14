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
        private static readonly HttpClientInstance _client = new HttpClientInstance();
        private HttpClientInstance()
        {
           
        }
        

        public static HttpClientInstance Instance
        {
            get
            {
                return _client;
            }
        }
    }
}
