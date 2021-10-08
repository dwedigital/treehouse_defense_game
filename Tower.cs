namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private const double _accuracy = .75;

        private static readonly System.Random _random = new System.Random();
        
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccesfulShot(){
            return _random.NextDouble() <_accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
                if(_location.InRangeOf(invader.Location,_range) && invader.IsActive){
                    System.Console.WriteLine("In range");
                    if(IsSuccesfulShot()){
                        invader.DecreaseHealth(_power);
                        System.Console.WriteLine("SHot and hit");

                        if(invader.IsNeutralized){
                            System.Console.WriteLine("Killed");
                        }
                    }
                    else{
                        System.Console.WriteLine("SHot and missed");
                    }
                    
                    break;
                }

            }
        }
    }
}
