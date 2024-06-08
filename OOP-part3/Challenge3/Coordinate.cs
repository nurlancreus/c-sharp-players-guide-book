using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part3.Challenge3
{
    internal readonly struct Coordinate(int x, int y)
    {
        public int X { get; } = x;
        public int Y { get; } = y;

        public bool IsAdjacentTo(Coordinate other)
        {
            return (Math.Abs(X - other.X) == 1 && Y == other.Y) || (Math.Abs(Y - other.Y) == 1 && X == other.X);
        }
    }
}
