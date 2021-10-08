namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException(){

        }
        public TreehouseDefenseException(string message){

        }

    }
    class OutOfBoundsException : TreehouseDefenseException
    {
        //default constructor calles the default constructor of its base if no parameters so no need to name it
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}