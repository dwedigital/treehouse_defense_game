namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            
            int index = 0;
            foreach (Invader invader in invaders)
            {
                if(_location.InRangeOf(invader.Location,_range) && invader.IsActive){
                    invader.DecreaseHealth(_power);
                    break;
                }

            }
        }
    }
}
