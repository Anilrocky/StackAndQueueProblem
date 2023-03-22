using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    public class LinkedListQueue
    {
        public Node head;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List Queue", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
        }
    }
}
