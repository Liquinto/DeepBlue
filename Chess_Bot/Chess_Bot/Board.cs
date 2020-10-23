using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Bot
{
    class Board
    {
        public Board()
        {
            Make_Board();
            Fill_Board();
        }

        static void Make_Board()
        {
            Tile[,] Board = new Tile[8, 8];
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (y < 2 && y > 5)
                    {
                        Tile tile = new Tile(true, x, y, null);
                        Board[x, y] = tile;
                    }
                    else
                    {
                        Tile tile = new Tile(false, x, y, null);
                        Board[x, y] = tile;
                    }
                }
            }
        }

        static void Fill_Board()
        {

        }
    }
}
