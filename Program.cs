﻿namespace QueueProblemUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
            queue.Dequeue();
            queue.DisplayQueue();
        }
    }
}