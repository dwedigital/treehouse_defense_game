namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public int Length=>_path.Length;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //brackets are not needed but help with readability
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        



    }
}