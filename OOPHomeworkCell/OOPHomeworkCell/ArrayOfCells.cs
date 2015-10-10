using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPHomeworkCell
{
    public class ArrayOfCells
    {
        public ArrayOfCells(int n, int m)
        {
            RowCount = n;
            ColumnCount = m;
        }

        public int RowCount { get; set; }
        public int ColumnCount { get; set; }

        public void ArrayGenerator()
        {

            Cell[,] cell = new Cell[RowCount, ColumnCount];


            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    cell[i, j] = new Cell();
                }
            }


            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    Console.Write("   " + cell[i, j]);
                    Thread.Sleep(100);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Neighbour neighbour = new Neighbour();
            neighbour.FindNeighbour(cell);
            
            Graph graph = new Graph();
            graph.CreateGraph(cell);
        }

        

    }
}
