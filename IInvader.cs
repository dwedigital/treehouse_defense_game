namespace TreehouseDefense
{
    interface IInvader
    {
        int Health { get; }
        MapLocation Location { get; }

        bool HasScored { get; }
        bool IsNeutralized { get; }

        bool IsActive { get; }


        void Move();

        void DecreaseHealth(int factor);
    }
}