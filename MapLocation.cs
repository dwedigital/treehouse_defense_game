namespace TreehouseDefense
{

    class MapLocation : Point
    // the colon indicates this inherits the Point class
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
    {
        // be careful calling this as not all fields will be constructed but base gets constructed first so safe to use
        if (!map.onMap(this))
        {
            throw new OutOfBoundsException($"{x},{y} is out of bounds of the map");
        }
    }
            public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location)<= range;
        }
    }
}