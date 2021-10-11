namespace TreehouseDefense
{

    interface IDamage
    {
        void DecreaseHealth(int factor);
    }

interface IMappable
{
    MapLocation Location { get; }
}
    interface IMove{
        void Move();
    }
    interface IInvader : IMove, IMappable, IDamage
    {
        int Health { get; }
        
        bool HasScored { get; }
        bool IsNeutralized { get; }

        bool IsActive { get; }

        
    }
}