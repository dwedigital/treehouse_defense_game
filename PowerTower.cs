namespace TreehouseDefense
{
    class PowerTower : Tower
    {
        protected override int Power{get;} = 2;
        public PowerTower(MapLocation location):base(location)
        {

        }
    }

        class RangeTower : Tower
    {
        protected override int Range{get;} = 2;
        public RangeTower(MapLocation location):base(location)
        {

        }
    }

}