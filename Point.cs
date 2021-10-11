using System;
namespace TreehouseDefense
{
    class Point
    {

        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;

        }
public override string ToString()
{
    return X + ", " + Y;
    
    }

        public int DistanceTo(int x, int y)
        {
            // int xDiff = X-x;
            // int yDiff = Y-y;
            // int xDiffSquared = xDiff * xDiff;
            // int yDiffSquared = yDiff * yDiff;
            // cast to int as we can not have a point inbetween squares
            // return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
