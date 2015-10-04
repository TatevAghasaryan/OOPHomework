using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeworkCell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input number of columns: ");
            int m = int.Parse(Console.ReadLine());
            ArrayOfCells ce = new ArrayOfCells(n, m);
            Console.WriteLine();
            Console.WriteLine();
            ce.ArrayGenerator();

            Console.ReadLine();
        }
    }
}
