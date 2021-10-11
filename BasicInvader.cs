namespace TreehouseDefense
{
    class BasicInvader : Invader{

        protected override int StepSize {get;} =1;
        public BasicInvader(Path path) :base(path){

        }

        public override void Move(){
            base.Move();
            System.Console.WriteLine("Quick mover");
        }
    }

}