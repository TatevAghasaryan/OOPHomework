using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeworkCell
{
    public class BFS
    {
        public void Bfs(Cell[][] CellsList, int size)
        {
            Queue<Cell> queue = new Queue<Cell>();
            List<Cell> output = new List<Cell>();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < CellsList[i].Length; j++)
                {
                    if (CellsList[i][j] != null && CellsList[i][j].Visited == false)
                    {
                        queue.Enqueue(CellsList[i][j]);
                        output.Add(CellsList[i][j]);
                        CellsList[i][j].Visited = true;
                    }
                    else
                    {
                        continue;
                    } 
                
                }
                
            }
            
            foreach (var item in queue)
            {
                Console.Write(" " + item);
            }
        }
    }
}
