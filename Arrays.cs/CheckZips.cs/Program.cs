using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 10 zip codes");
            int[] Zip = new int[10];
            for (int i = 0; i < Zip.Length; i++)
            {
                Zip[i] = Convert.ToInt32(Console.ReadLine());
                if (Zip[i] > 10000)
                {
                    Console.WriteLine("Not within delivery range");
                }
                else
                {
                    Console.WriteLine("You are within Range");
                }
            }
        }
    }
}
