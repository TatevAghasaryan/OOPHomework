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
        static void Main(string[] args)
        {
            HttpClientInstance c = HttpClientInstance.GetHtml();
            Console.ReadKey();
        }
    }
}
