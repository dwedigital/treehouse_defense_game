namespace TreehouseDefense
{
    class FastInvader : Invader{

        protected override int StepSize {get;} =2;
        public FastInvader(Path path) :base(path){

        }

        public override void Move(){
            base.Move();
            System.Console.WriteLine("Quick mover");
        }
    }

}