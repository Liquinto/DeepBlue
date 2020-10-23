using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Bot
{
    class Rook : Piece
    {
        public Rook(int colour, int x, int y, bool is_in_start_state) : base(colour, x, y, is_in_start_state) { }
        public override void Move()
        {
        }
    }
}
