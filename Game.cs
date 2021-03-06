using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);


            try
            {
                Path path = new Path(
                    new[]{
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map)
                    }
                );
            
            IInvader[] invaders = {
                new ResurrectingInvader(path),
                new ShieldedInvader(path),
                new FastInvader(path),
                new StrongInvader(path),
                new BasicInvader(path)

            };

            

            Tower[] towers ={
                new Tower(new MapLocation(1,3,map)),
                new Tower(new MapLocation(2,3,map)),
                new PowerTower(new MapLocation(3,3,map)),
                new PowerTower(new MapLocation(4,3,map)),
                new RangeTower(new MapLocation(4,3,map))

            };
            // when creating an object you can set multipl properties like below
            Level level = new Level(invaders){
                Towers = towers
            };
            bool playerWon = level.Play();
            Console.WriteLine("Player "+(playerWon?"won":"lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled Treehouse Defense Exception");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}