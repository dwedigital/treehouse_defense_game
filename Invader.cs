namespace TreehouseDefense
{
    abstract class Invader :IInvader
    {
        private readonly Path _path;
        // private readonly int _pathLength = _path.length();
        private int _pathStep = 0;
        protected virtual int StepSize{get;} = 1;
        public virtual int Health { get; protected set; } = 2;
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public bool HasScored {get{return _pathStep >=_path.Length;}}
        public bool IsNeutralized => Health <=0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;

        }

        public virtual void Move() => _pathStep+=StepSize;

        public  virtual void DecreaseHealth(int factor) => Health -= factor;

    }
}