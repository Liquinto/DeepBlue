using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Bot
{
    class Pawn : Piece
    {
        public Pawn(int colour, int x, int y, bool is_in_start_state) : base(colour, x, y, is_in_start_state) { }
        public override void Move()
        {

        }
    }
}
