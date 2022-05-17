using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp2
{

    class Node<T>
    {
        public T Value { get; set; }
        public Node <T> Left { get; set; }
        public Node <T> Right { get; set; }
    }


    class Tree<T>
    { 
        public Node<T> Root { get; set; }
        public void PreOrderTraversal(Action <Node<T>> action)
        {
            PreOrder(Root, action);
            
        
        }

        public void PreOrder(Node<T> node, Action<Node<T>> action)
        {
            
            
            action.Invoke(node);   //??????


            if (node.Left !=null)
            {
                PreOrder(node.Left, action);

            }
            
            
            if (node.Right != null)
            {
                PreOrder(node.Right, action);

            }
            
        }

        public void PostOrderTraversal(Action<Node<T>> action)
        {
            PostOrder(Root, action);


        }

        public void PostOrder(Node<T> node, Action<Node<T>> action)
        {
            PostOrder(node.Left, action);


        }


        public void InOrderTraversal(Action<Node<T>> action)
        {
            InOrder(Root, action);


        }

        public void InOrder(Node<T> node, Action<Node<T>> action)
        {
            InOrder(node.Left, action);


        }


        public void LevelTraversal(Action<Node<T>> action)
        {
            Queue<Node<T>> q = new Queue<Node<T>>();

            

        }
        public List<T[]> GetPaths()
        {
            Stack<T> stack = new Stack<T>();
            List<T[]> list = new List<T[]>();
            GetPaths(Root, stack, list);
            return list;
        }

        public void GetPaths(Node<T> node , Stack<T> stack, List<T[]> list)
        {
            stack.Push(node.Value);
            if (node.Left == null && node.Right == null)
            {
                list.Add(stack.ToArray());
                stack.Pop();
                return;
                
                
            }
            if (node.Left == null)
            {
                GetPaths(node.Left, stack, list);
            }
            if (node.Right == null)
            {
                GetPaths(node.Right, stack, list);
            }
            stack.Pop();
        }



    }



    class Expression : Tree<string>
    {
        double Evaluate(Node<string> node)
        {
            return  EvaluateNode(node);





        }

        private double EvaluateNode(Node<string> node)
        {
            switch (node.Value)
            {
                case "+":
                    return EvaluateNode(node.Left) + EvaluateNode(node.Right);
                    break;
                case "-":
                    return EvaluateNode(node.Left) - EvaluateNode(node.Right);
                    break;

                case "*":
                    return EvaluateNode(node.Left) * EvaluateNode(node.Right);
                    break;
                case "/":
                    return EvaluateNode(node.Left) / EvaluateNode(node.Right);
                    break;
                default:
                    return double.Parse(node.Value);
                    break;
            }
        
        
        
        }
    

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node<string> node = new Node<string>() { Value = "A" };
            node.Left = new Node<string>() { Value = "B" };
            node.Right = new Node<string>() { Value = "C" };

            Tree<string> tree = new Tree<string> { Root = node };
            tree.PreOrderTraversal(node => Console.WriteLine(node.Value));
            Node<string> node1 = new Node<string>() { Value = "A" };


            //PreOrder ABDECFG
            //PostOrder
            //InOrder DBEAFCG

            /*
             * 
             *                  A  
             *          B               C
             *      D       E       F      G      
             * 
             * 
             * 
             * 
             * 
            */

        }
    }
}
