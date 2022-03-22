using System;

namespace ConsoleApp1
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int[] arrToSort = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int n = 10, i;

            Console.Write("Nieposortowana tablica: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(arrToSort[i] + " ");
            }
            quickSort(arrToSort, 0, arrToSort.GetLength(0) - 1);
            
            Console.WriteLine();
            Console.Write("Posortowana tablica: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(arrToSort[i] + " ");
            }
            Console.WriteLine();
        }

        static public int Partition(int[] arrToSort, int begin, int last)
        {
            

            int pivot;
            pivot = arrToSort[begin];
            while (true)
            {

                while (arrToSort[begin] < pivot)
                begin++;
                

                while (arrToSort[last] > pivot)
                last--;
               

                if (begin < last)
                {
                    int temp = arrToSort[last];
                    arrToSort[last] = arrToSort[begin];
                    arrToSort[begin] = temp;
                }

                else
                {
                    return last;
                }
            }
        }
        static public void quickSort(int[] arrToSort, int begin, int last)
        {
            int pivot;
            if (begin < last)
            {
                pivot = Partition(arrToSort, begin, last);
                if (pivot > 1)
                quickSort(arrToSort, begin, pivot - 1);
                
                if (pivot + 1 < last)
                quickSort(arrToSort, pivot + 1, last);
                
            }
        }
        
    }

}
