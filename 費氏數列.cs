using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i < a.Length; i++)
            {
                a[i] = a[i-1] + a[i-2];
                Console.WriteLine(a[i]);
            }
        }
    }


}