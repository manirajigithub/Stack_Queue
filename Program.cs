namespace QueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stack");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
        }
    }
}