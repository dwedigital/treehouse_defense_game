namespace TreehouseDefense
{
    class StrongInvader : Invader{

        public override int Health { get; protected set; } = 3;
        public StrongInvader(Path path) :base(path){

        }

        public override void Move(){
            base.Move();
            System.Console.WriteLine("Quick mover");
        }
    }

}