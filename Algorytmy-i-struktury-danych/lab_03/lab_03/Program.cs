using System;
using System.Collections.Generic;

namespace lab_03_01
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; i < 10; i++)
                Console.WriteLine(fibonnacio(i));
            /*
            for(int i=1; i<7; i++)
            Console.WriteLine(fibonnaci(i));


            
            long fibMem(int n, Dictionary<int, long> mem)
            {
                if (n < 2)
                {
                    return 1;
                }

                if (!mem.ContainsKey(n - 1))
                {
                    mem[n - 1] = fibMem(n - 1, mem);
                }
                if (!mem.ContainsKey(n - 2))
                {
                    mem[n - 2] = fibMem(n - 2, mem);
                }
                return mem[n - 1] + mem[n - 2];
            }
            
            long fibonnaci(int n)
            {
                return fibMem(n, new Dictionary<int, long>());
            }
            */


            int fibonnacio(int n)
            {

                int a;
                int b;

                if (n < 2)
                {
                    return 1;
                }

                if (n < 3)
                {
                    return 2;
                }

                if (n > 2)
                {
                    a = fibonnacio(n - 1);
                    b = fibonnacio(n - 2);
                    return a + b;
                }
                return 45454;
                
            }
        }

        
    }
}
