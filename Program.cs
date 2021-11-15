//program to sort an integer array
using System;

namespace sortarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 12, 34, 14, 1, 23, 9, 10 };
            Array.Sort(numb);
           foreach(int i in numb)
            {

                Console.WriteLine(i);

            }

        }
    }
}
