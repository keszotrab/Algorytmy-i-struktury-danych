using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {/*Console.WriteLine("Hello World!");


            List<int> banan = new List<int>();

            banan.Add(1);
            banan.Add(14);
            banan.Add(1123);
            banan.Add(14);
            banan.Add(2137);

            foreach (var item in banan)
            {
                Console.WriteLine("To : " + item);
            }


            //If(head.next = this.next)
            //      return true ?
            */
            }



            Node<string> node = new Node<string> { Value = " 12 41 24 1290 4912" };
            node.Next = new Node<string> { Value = "     214  - 1243          912312" };
            node.Next.Next = new Node<string> { Value = "179 53 1  124  09-121 18 " };
            node.Next.Next.Next = node;
            Node<string> head = node;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }






        }
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public T Add()
            {
                   // ma zwracac zmienna utworzona w  klasie np[. T cokolwiek;
                //return T Value; 
            }
        
        
        
        }


        
        class bambam
        {

        }


    }


}


    

