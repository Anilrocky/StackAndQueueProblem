using System;
namespace StackAndQueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedListStack stack = new LinkedListStack();
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Push elements to Stack \n2.Display \n3.Peek and Pop elements \n4.Queues problem \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        break;
                    case 2:
                        stack.Display();
                        break;
                    case 3:
                        stack.Peek();
                        stack.Pop();
                        break;
                    case 4:                        
                        LinkedListQueue queue = new LinkedListQueue();
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("\nChoose option to perform \n1.Create queue \n2.Display \n3.Exit");
                            int a = Convert.ToInt32(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    queue.Enqueue(56);
                                    queue.Enqueue(30);
                                    queue.Enqueue(70);
                                    break;
                                case 2:
                                    queue.Display();
                                    break;                              
                                case 3:
                                    flag1 = false;
                                    break;
                            }
                        }                       
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}

