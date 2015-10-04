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

            FindNeighbour(cell);
        }

        public void FindNeighbour(Cell[,] cell)
        {
            int RoCount = cell.GetLength(0);
            int ColCount = cell.GetLength(1);

            for (int i = 0; i < RoCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    if (i == 0)
                    {
                        cell[i, j].Top = null;
                    }
                    else
                    {
                        cell[i, j].Top = cell[i - 1, j];
                    }


                    if (j == 0)
                    {
                        cell[i, j].Left = null;
                    }
                    else
                    {
                        cell[i, j].Left = cell[i, j - 1];
                    }


                    if (i == RoCount - 1)
                    {
                        cell[i, j].Bottom = null;
                    }
                    else
                    {
                        cell[i, j].Bottom = cell[i + 1, j];
                    }


                    if (j == ColCount - 1)
                    {
                        cell[i, j].Right = null;
                    }
                    else
                    {
                        cell[i, j].Right = cell[i, j + 1];
                    }

                    Console.WriteLine("i= {0} j = {1} Top: {2} Right: {3} Left: {4} Bottom: {5}", i, j, cell[i, j].Top, cell[i, j].Right, cell[i, j].Left, cell[i, j].Bottom);

                    Console.WriteLine();
                    Thread.Sleep(200);
                }
            }
        }

    }
}
