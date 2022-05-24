using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{

    interface IGraph
    {
        bool AddDirectedEdge(int source, int target, int weight);
        bool AddUndirectedEdge(int source, int target, int weight);
        void Traversal(int start, Action<int> action);

    }

    class AddMatrixGraph : IGraph
    {
        private int[,] _matrix;
        public AddMatrixGraph(int size)
        { 
            _matrix = new int[size, size];
        }

        public bool AddDirectedEdge(int source, int target, int weight)
        {
            if (source >= 0 && source < _matrix.GetLength(0) && target >= 0 && target < _matrix.GetLength(1))
            {
                _matrix[source, target] = weight;
                return true;
            }
            else 
            {
                return false;            
            }
        
        
        }

        public bool AddUndirectedEdge(int source, int target, int weight)
        {
            return AddDirectedEdge(source, target, weight) && AddDirectedEdge(target, source, weight);
        }

        public void Traversal(int start, Action<int> action)
        {

            //uzu
            foreach (var item in collection)
            {
                //uzu asdsadddddddddddddddddddddddddddddddddddddddddddddddddddddddddddasdsaddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd 
            }


        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < _matrix.GetLength(0); row++)
            {
                sb.Append($"wierzchołek {row} ma krawędzie z : ");

                for (int col = 0; col < _matrix.GetLength(1); col++)
                {
                    if (_matrix[row,col] != 0)
                    {
                        sb.Append(col + " ");
                    }
                }
                sb.AppendLine();

            }

            return sb.ToString();


            
        }
    }


    class AddListGraph : IGraph
    {

        private Dictionary<int, HashSet<Edge>> _edges = new Dictionary<int, HashSet<Edge>>();

        public bool AddDirectedEdge(int source, int target, int weight)
        {
            if (!_edges.ContainsKey(source))
            {
                _edges.Add();
                //uzu asdsadddddddddddddddddddddddddddddddddddddddddddddddddddddddddddasdsaddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd

            }
            _edges[source].Add(new Edge() { Target = target, Weight = weight });

            return true;
        }

        public bool AddUndirectedEdge(int source, int target, int weight)
        {
            throw new NotImplementedException();
        }

        public void Traversal(int start, Action<int> action)
        {
            
            Queue<int> q = new Queue<int>();
            HashSet<int> visited = new HashSet<int>;
            q.Enqueue(start);
            while (q.Count > 0)
            {
                int node = q.Dequeue();
                if (visited.Contains(node))
                {
                    ///////uzu 
                }
            
            
            }




        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in _edges)
            {
                sb.Append($"wierzchołek {_edges} ma krawędzie z : ");
                foreach ( var edge in item.Value)
                {
                sb.Append($"wierzchołek {edge.Target} ma krawędzie z : ");

                }
            }
            return sb.ToString();
        }
    }

    record Edge
    { 
        public int Target { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            IGraph graph = new AddMatrixGraph(4);
            graph.AddDirectedEdge(0, 2, 3);
            graph.AddDirectedEdge(1, 2, 2);
            graph.AddDirectedEdge(2, 0, 8);
            graph.AddUndirectedEdge(2, 3, 1);
            graph.AddDirectedEdge(3, 3, 1);

            Console.WriteLine(graph);

            Console.WriteLine("Hello World!");


            Console.WriteLine();

            IGraph graph2 = new AddListGraph();
            graph2.AddDirectedEdge(0, 2, 3);
            graph2.AddDirectedEdge(1, 2, 2);
            graph2.AddDirectedEdge(2, 0, 8);
            graph2.AddUndirectedEdge(2, 3, 1);
            graph2.AddDirectedEdge(3, 3, 1);

            Console.WriteLine(graph2);
            graph2.Traversal(0, node => Console.WriteLine(node)); ////????????????????
            



            // na next zajeia 31.05

            //Lab 12 praca jedno z nich. 
            //Algorytm Kruskala
            // bedzie korzystane i cwiczonka



        }
    }
}
