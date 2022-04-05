using System;

namespace ConsoleApp1
{

    class IntQueue
    {

        public readonly static int Capacity = 3;
        private int[] arr = new int[Capacity];
        private int last = -1;
        private int first = -1;
        private int count = 0;

        public bool Insert(int value)
        {
            if (count == Capacity)
                throw new Exception();
            if (last == Capacity - 1)
                last = (last % Capacity) -1; 
            arr[++last] = value;
            count++;
            return true;
        }

        public int Remove()
        {
            if (count == 0)
            throw new Exception();

            if (first == Capacity - 1)
                first = (first % Capacity) - 1;
            count--;
            return arr[++first];

        }


    }

    class PriorityQueue
    {

        public readonly static int Capacity = 5;
        private int[] arr = new int[Capacity];
        private int last = -1;
        int count = 0;

        private int LeftChild(int parent)
        {

            return 0; 
        }

        private int RightChild(int parent)
        {

            return 0;
        }




        public bool Insert(int value)
        {
            

            return true;
        }

        public int Remove()
        {
            int removed = arr[0];
            arr[0] = arr[last--];
            RebuildDown();


            return 0;
        }

        public void RebuildDown()
        {

            int node = 0;
            while (node >= last)
            {
                int leftChildValue = arr[LeftChild(node)];
                int rightChildValue = arr[RightChild(node)];
                if (arr[node] > leftChildValue && arr[node] > rightChildValue)
                {
                    break;
                }
                if (leftChildValue >= rightChildValue)
                {
                    (arr[node], arr[LeftChild(node)]) = (arr[LeftChild(node)], arr[node]);


                }

                if (rightChildValue > leftChildValue)
                {
                    (arr[node], arr[RightChild(node)]) = (arr[RightChild(node)], arr[node]);

                }



            }

        }




    }

    




    class Program
    {
        static void Main(string[] args)
        {
            IntQueue dabidamdam = new IntQueue();
            dabidamdam.Insert(4);
            dabidamdam.Insert(3);
            dabidamdam.Insert(1);

            Console.WriteLine(dabidamdam.Remove());
            Console.WriteLine(dabidamdam.Remove());
            Console.WriteLine(dabidamdam.Remove());
            dabidamdam.Insert(69);
            Console.WriteLine(dabidamdam.Remove());

            
            

        }
    }
}
