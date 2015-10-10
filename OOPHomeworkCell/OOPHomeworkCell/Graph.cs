using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeworkCell
{
    public class Graph
    {


        public void CreateGraph(Cell[,] cell)
        {
            Console.WriteLine("Input start coordinate of I");
            int StartI = int.Parse(Console.ReadLine());

            Console.WriteLine("Input start coordinate of J");
            int StartJ = int.Parse(Console.ReadLine());

            Console.WriteLine("Input end coordinate of I");
            int EndI = int.Parse(Console.ReadLine());

            Console.WriteLine("Input end coordinate of J");
            int EndJ = int.Parse(Console.ReadLine());
            int k = 0;

            int size = (EndI - StartI + 1) * (EndJ - StartJ + 1);
            Cell[][] CellsList = new Cell[size][];



            if (EndI < StartI && EndJ < StartJ)
            {
                int a = StartI;
                StartI = EndI;
                EndI = a;
                int b = StartJ;
                StartJ = EndJ;
                EndJ = b;
            }

            for (int i = 0; i < CellsList.GetLength(0); i++)
            {
                CellsList[i] = new Cell[5];

            }


            for (int i = StartI; i <= EndI; i++)
            {
                for (int j = StartJ; j <= EndJ; j++)
                {
                    CellsList[k][0] = cell[i, j];
                    CellsList[k][1] = cell[i, j].Top;
                    CellsList[k][2] = cell[i, j].Right;
                    CellsList[k][3] = cell[i, j].Bottom;
                    CellsList[k][4] = cell[i, j].Left;

                    //Console.Write("Value: {0} Top: {1} Right: {2} Bottom: {3} Left: {4} ", CellsList[k][0], CellsList[k][1], CellsList[k][2], CellsList[k][3], CellsList[k][4]);

                    //Console.WriteLine();
                    k++;

                }
            }


            BFS bfs = new BFS();
            bfs.Bfs(CellsList, size);

        }



        

    }
}
