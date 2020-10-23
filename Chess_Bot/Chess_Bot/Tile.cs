using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Bot
{
    class Tile
    {
        bool Occupied;
        Piece Occupied_by;
        int X;
        int Y;

        public Tile(bool occupied, int x, int y, Piece occupied_by)
        {
            occupied = Occupied;
            x = X;
            y = Y;
            occupied_by = Occupied_by;
        }
    }
}
