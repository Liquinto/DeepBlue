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

        public Piece()
        {
        }

        public abstract void Move();

    }
}
