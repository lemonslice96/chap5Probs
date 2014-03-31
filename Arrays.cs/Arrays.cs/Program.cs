 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] Integers = new int[5] { 65, 50, 49, 24, 92 };
            for (int i = 0; i < Integers.Length; i++)
            {
                Array.Sort(Integers);
                Array.Reverse(Integers);
                Console.WriteLine("{0}", Integers[i]);
            }
        }
    }
}
