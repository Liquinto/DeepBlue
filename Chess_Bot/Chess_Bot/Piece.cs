using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Bot
{
    abstract class Piece
    {
        int Colour;
        int X;
        int Y;
        bool Is_in_start_state;

        public Piece(int colour, int x, int y, bool is_in_start_state)
        {
            colour = Colour;
            x = X;
            y = Y;
            is_in_start_state = Is_in_start_state;
        }

        public abstract void Move();

    }
}
