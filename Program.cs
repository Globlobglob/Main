using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            int[] myArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                for (int x = 0; x < 8; x++)
                {
                    Console.Write($"mass[{i}]=");
                  myArray[x] = Convert.ToInt32(Console.ReadLine());
                }
                for(int x=0;x<8;x++)
                {
                    Console.WriteLine($"mass[{x}]={myArray[x]}");
                }
            */

            //2
            /*
            int[] myArray = new [] { -5,-6,-7,5,6,7,8};
            for (int x = 0; x< myArray.Length; x++)
            {
                if (myArray[x] > 0)
               {
                    Console.WriteLine(myArray[x]);
               }
            }
            */
            //3
            /*
            int[] myArray = { -7, 10, 5, 16, -4, 18 };

            for (int x = myArray.Length - 1; x >= 0; x--)
            {
                Console.WriteLine(myArray[x]);
            }
            */

            //4
            /*
            int[] heights = new int[12];
            Random rnd = new Random();

            for (int x = 0; x < heights.Length; x++)
            {
                heights[x] = rnd.Next(163, 191);
            }

            foreach (int height in heights)
            {
                Console.WriteLine(height);

            }*/

        }
    }
}
