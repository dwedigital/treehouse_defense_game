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

                Invader invader = new Invader(path);
    
                Console.WriteLine(invader.Health);
                invader.DecreaseHealth(10);
                Console.WriteLine(invader.Health);
                Console.WriteLine(invader.IsNeutralized);
                Console.WriteLine(invader.HasScored);
                Console.WriteLine($"{invader.Location.X}, {invader.Location.Y}");
                invader.Move();
                Console.WriteLine($"{invader.Location.X}, {invader.Location.Y}");
            

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