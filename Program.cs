namespace StackProblemUC2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stack");
            Stack stack1 = new Stack();
            stack1.StackPush(70);
            stack1.StackPush(30);
            stack1.StackPush(56);
            stack1.Peak();
            stack1.Display();

        }
    }
}

           

