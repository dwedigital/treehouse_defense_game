namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range{get;} = 1;
        protected virtual int Power{get;} = 1;

        protected virtual double Accuracy{get;} = .75;

        private static readonly System.Random _random = new System.Random();
        
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccesfulShot(){
            return _random.NextDouble() <Accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
                if(_location.InRangeOf(invader.Location,Range) && invader.IsActive){
                    System.Console.WriteLine("In range");
                    if(IsSuccesfulShot()){
                        invader.DecreaseHealth(Power);
                        System.Console.WriteLine("Shot and hit");

                        if(invader.IsNeutralized){
                            System.Console.WriteLine("Killed invader at "+invader.Location);
                            
                        }
                    }
                    else{
                        System.Console.WriteLine("Shot and missed");
                    }
                    
                    break;
                }

            }
        }
    }
}
