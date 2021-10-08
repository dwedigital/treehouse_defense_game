namespace Treehouse.CodeChallenges
{
    class Polygon
    {
        public readonly int NumSides;
        public Polygon(int numSides)
        {
            NumSides = numSides;
        }
    }

    class Square : Polygon
    {

        public readonly int SideLength;

        public Square(int sideLength) : base(4)
        {
            SideLength = sideLength;

        }

    }
}