using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class Queue
    {

        Node front;
        Node rear;

        public Queue()
        {
            this.front = null;
            this.rear = null;                        // Initialize Both ends as null
        }

        internal void Enqueue(int item)
        {
            Node newNode = new Node(item);

            // Enqueue starts from rare end
            if (this.rear == null)                            //if rare is null then it points to newNode
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // if it not null then it will insert the new node and change the value of rear 
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} Added into Queue", item);
        }
        internal void Dequeue()
        {

            if (this.front == null)
            {
                Console.WriteLine("Empty");
                return;
            }


            Node temp = this.front;                     // Store old front and move ahead one node  
            this.front = this.front.next;


            if (this.front == null)
            {
                this.rear = null;               // If front null, rear also null  
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
        public void DisplayQueue()
        {
            Node front = this.front;
            if (front == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while (front != null)
            {
                Console.WriteLine(front.data + " ");
                front = front.next;
            }
        }
    }
}
