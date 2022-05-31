using System;

namespace lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            if (
                IsPalindrome("a")
                && IsPalindrome("aaa")
                && IsPalindrome("")
                && IsPalindrome("zakaz")
                && IsPalindrome("ZaKAZ")
                && IsPalindrome("KamilŚlimak")
                && !IsPalindrome("abc")
                )
            {
                Console.WriteLine("Zadanie 1: ok");
                points += 1;
            }
            if (
                IsAnagrams("abcd", "bcda")
                && IsAnagrams("aa", "aa")
                && !IsAnagrams("AA", "aa")
                && IsAnagrams("", "")
                && !IsAnagrams("abc", "abca")
                )
            {
                Console.WriteLine("Zadanie 2: ok");
               points += 1;
            }
            if (
                LongestIdenticalString("aaaa").Equals("aaaa")
                && LongestIdenticalString("abcddddaaddd").Equals("dddd")
                && LongestIdenticalString("abcd").Equals("a")
                && LongestIdenticalString("abbcdd").Equals("bb")
                )
            {
                Console.WriteLine("Zadanie 3: ok");
                points += 2;
            }
            Console.WriteLine("points: " + points);
        }


        //czy input jest palindromem
        public static bool IsPalindrome(string input)
        {
            
            int d;
            int z = input.Length;



            if (input.Length % 2 == 0)
            {
                d = input.Length / 2;
            }
            else
            {
                d = (input.Length - 1)/2;           
            }


            string temp = input.ToLower();

            char[] inputArr = new char[input.Length];
            inputArr = temp.ToCharArray(0,input.Length);

           
            
            for (int i = 0; i < d; i++)
            {
                if (inputArr[i] != inputArr[z-i-1])
                {
                    return false;
                }
            
            }
            return true;
        }


        public static bool IsAnagrams(string a, string b)
        {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b))
                return true;

            if (a.Length != b.Length)
                return false;


            int temp;
            int sumA =0;
            int sumB =0;


            char[] arrA = new char[a.Length];
            arrA = a.ToCharArray(0, a.Length);

            char[] arrB = new char[b.Length];
            arrB = b.ToCharArray(0, b.Length);

            foreach (var item in arrA)
            {
                sumA += item;
            }
            foreach (var item in arrB)
            {
                sumB += item;
            }

            if (sumA == sumB)
            {
                sumA = 0;
                sumB = 0;

                foreach (var item in arrA)
                {
                    sumA *= item;
                }
                foreach (var item in arrB)
                {
                    sumB *= item;
                }

                if (sumA == sumB)
                    return true;
            }


            return false;


        }


        //zwróć pierwszy najdłuższy fragment złożony z powtarzających się znaków wejścia
        public static string LongestIdenticalString(string input) 
        {



            return "";
        }

}
}
