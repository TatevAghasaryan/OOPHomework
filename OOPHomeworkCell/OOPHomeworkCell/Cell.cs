using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPHomeworkCell
{
    public class Cell
    {
        public Cell()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            Value = rnd.Next(1, 100);
        }

        public bool Visited { get; set; }
        public Cell Top { get; set; }
        public Cell Bottom { get; set; }
        public Cell Left { get; set; }
        public Cell Right { get; set; }

        public int Value { get; set; }


        public override string ToString()
        {
            return string.Format("{0}", Value);
        }

    }
}
