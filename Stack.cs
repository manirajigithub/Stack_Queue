using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblemUC2
{
    internal class Stack
    {

        Node head;

        public Stack()
        {
            this.head = null;
        }

        public void StackPush(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = head;
            }
            head = newNode;
            Console.WriteLine("{0} Added to stack", value);
        }
        public void Pop()
        {
            Node newNode = head;
            if (head == null)
            {
                newNode.next = null;
                Console.WriteLine("Empty , Nothing to pop");
                return;
            }
            else
            {
                while (head != null)
                {
                    Console.WriteLine("Popped Item is {0}", head.data);
                    head = head.next;
                }
            }
        }
        public void Peak()
        {

            if (head == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            else
            {
                Console.WriteLine("{0} is on the top ", this.head.data);

            }

        }


        public void Display()
        {
            Node head = this.head;
            if (head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while (head != null)
            {
                Console.WriteLine(head.data + " ");
                head = head.next;
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}