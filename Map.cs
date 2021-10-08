namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        // constructor methods do not need to have return type as they do not return anything
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            
        }
        public bool onMap(Point point)
        {
            return  point.X >= 0 && point.X <= Width && 
                    point.Y >= 0 && point.Y <= Height;
        }


    }
}