using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryCharge.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Zip = new int[10] { 24343, 14523, 94522, 25432, 61236, 86732, 24532, 34556, 79432, 83322 };
            float[] Charge = new float[10] { .05f, .1f, .15f, .2f, .25f, .3f, .35f, .4f, .45f, .5f };
            Console.WriteLine("Enter your code of zip (24343, 14523, 94522, 25432, 61236, 86732, 24532, 34556, 79432, 83322): ");
            int Zipinput = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < Zip.Length; i++)
            {
                
                if (Zip[i] > 10000)
                {
                    
                }
            }
        }
    }
}
