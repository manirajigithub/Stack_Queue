using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    internal class Stack
    {

        Node head;

        public Stack()
        {
            this.head = null;
        }

        internal void StackPush(int value)
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

        public void DisplayStack()
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
        }
    }
}