using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ");
                
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }

            }
            Console.ReadKey();
        }
    }
}
