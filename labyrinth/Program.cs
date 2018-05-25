using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell[,] cells = new Cell[6, 6];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6;j++)
            {
                    cells[i, j] = new Cell();
            }
            
            //cells[0].Bottom = cells[1];
            //cells[1].Bottom = cells[2];
            //cells[2].Bottom = cells[3];
            //cells[3].Bottom = cells[4];
            //cells[5].Right = cells[6];
            //cells[6].Right = cells[7];
            //cells[7].Top = cells[8];
            //cells[8].Top = cells[9];
            //cells[15]
            cells[0, 0].Bottom = cells[0, 1];
            cells[0, 1].Bottom = cells[0, 2];
            cells[0, 1].Top = cells[0,0];
            cells[0, 2].Bottom = cells[0, 3];
            cells[0, 2].Top = cells[0, 1];
            cells[0, 3].Bottom = cells[0, 4];
            cells[0, 3].Top = cells[0, 2];
            cells[0, 4].Bottom = cells[0, 5];
            cells[0, 4].Top = cells[0, 3];
            cells[0, 5].Right = cells[1, 5];
            cells[0, 5].Top = cells[0, 4];
            cells[1, 0].Bottom = cells[1, 1];
            cells[1, 0].Left = cells[2, 0];
            cells[1, 1].Right = cells[2, 1];
            cells[1, 2].Bottom = cells[1, 3];
            cells[1, 2].Right = cells[2, 2];
            cells[1, 3].Bottom = cells[1, 4];
            cells[1, 3].Right = cells[2, 3];
            cells[1, 4].Top = cells[1, 3];
            cells[1, 5].Left = cells[0, 5];
            cells[1, 5].Right = cells[2, 5];

            Labyrinth labyrinth = new Labyrinth(cells, new Marker());            
            MoveService moveService = new MoveService(labyrinth);
           
            moveService.MoveDown();
            moveService.MoveDown();
            moveService.MoveDown();
            moveService.MoveDown();
            moveService.MoveDown();
            moveService.MoveRight();
            moveService.MoveRight(); 
            //////////////////////далее не успел//////////////////////////////

        }
    }
}
