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
            HtmlSource html = new HtmlSource();

            HttpClientInstance c1 = HttpClientInstance.Instance;
            HttpClientInstance c2 = HttpClientInstance.Instance;

            Console.WriteLine(object.ReferenceEquals(c1,c2));
            Console.ReadKey();
        }
    }
}
