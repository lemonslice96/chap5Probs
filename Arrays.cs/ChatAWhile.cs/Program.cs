using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Minutes;
            int[] Area = new int[6] { 262, 414, 608, 715, 815, 920 };
            double[] Cost = new double[6] { 0.07d, 0.10d, 0.05d, 0.16d, 0.24d, 0.14d };

            Console.WriteLine("Enter area code: 262, 414, 608, 715, 815, 920");
            int Areainput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter minutes of chattingness:");
            Minutes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= Area.Length; i++)
            {
                if (Areainput == Area[i])
                {
                    Console.WriteLine("The cost of your call is ${0}", Cost[i] * Minutes);
                }
            }
        }
    }
}
