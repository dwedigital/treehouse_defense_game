namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        // private readonly int _pathLength = _path.length();
        private int _pathStep = 0;
        public int Health { get; private set; } = 2;
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public bool HasScored {get{return _pathStep >=_path.Length;}}
        public bool IsNeutralized => Health <=0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;

        }

        public void Move() => _pathStep++;

        public void DecreaseHealth(int factor) => Health -= factor;

    }
}