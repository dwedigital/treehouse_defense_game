namespace TreehouseDefense
{

    class Level
    {
        private readonly IInvader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {


            int remainingInvaders = _invaders.Length;
            // run until all invaders are neutralised or an invader gets to the end of the pathStep
            while (remainingInvaders > 0)
            {
                // each tower has the chance to fire on invaders that
                foreach (Tower tower in Towers)
                {
    
                    tower.FireOnInvaders(_invaders);
                }
                remainingInvaders = 0;
                //count and move the invaders that are still active
                foreach (IInvader invader in _invaders)
                {

                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            // player has lost
                            return false;
                        }

                        remainingInvaders++;
                    }

                }

            }
            // player has won
            return true;




        }
    }
}

//