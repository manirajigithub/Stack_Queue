namespace StackProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stack and Queue");



            Stack stack = new Stack();
            stack.StackPush(70);
            stack.StackPush(30);
            stack.StackPush(56);
            stack.DisplayStack();
        }
    }
}

               