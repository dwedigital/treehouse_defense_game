namespace TreehouseDefense
{

    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            // run until all invaders are neutralised or an invader gets to the end of the pathStep

            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {

                foreach (Tower tower in Towers)
                {

                    tower.FireOnInvaders(_invaders);
                }
                remainingInvaders = 0;

                foreach (Invader invader in _invaders)
                {

                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {

                            return false;
                        }

                        remainingInvaders++;
                    }

                }
                
            }
            return true;

            // each tower has the chance to fire on invaders that

            //count and move the invaders that are still active
        }
    }
}

//