using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //FIFO
            Node<string> node = new Node<string> { Value = "adam" };
            node.Next = new Node<string> { Value = "ewa" };
            node.Next.Next = new Node<string> { Value = "Karol" };
            Node<string> head = node;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            
            }
            
            
            //LIFO
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }


            /* 
              

            z7

                
              
              
              
              
             
             
             
             
             
             
             
             
             
             
             */ 



        }


        class Node<T>
        { 
            public T Value { get; set; }
            public Node<T> Next { get; set; }
        }

        class Stack<T>
        {
            public T Value { get; set; }
            private Node<T> _head { get; set; }

            public void Push(T value)
            {
                Node<T> node = new Node<T> { Value = value };
                node.Next = _head;
                _head = node;
            }

            public bool IsEmpty()
            {
                return _head == null;
                
            }

            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new Exception("Stack is empty!");
                }

                T result = _head.Value;
                _head = _head.Next;
                return result;

            }
            
            
        }






    }
}
