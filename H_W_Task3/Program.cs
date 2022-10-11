using System;

namespace H_W_Task3
{
    internal class Program
    {

        /*Задачи на использование операторов цикла с предусловием. 
         * Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено
         * максимально возможное количество квадратов со стороной C (без наложений).
         * Найти количество квадратов, размещенных на прямоугольнике.
         * Операции умножения и деления не использовать.     */

        static void Main(string[] args)
        {
            int A, B, C, countA, countB;
            Console.Write("A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            C = Convert.ToInt32(Console.ReadLine());
            countA = 0;
            countB = 0;

            while (A >= C) //столбец
            {
                A -= C;
                while (B >= C) //строка
                {
                    B -= C;
                    countB += 1;
                }
                countA += countB;
            }

            Console.WriteLine("Количество квадратов = {0}", countA);
            Console.ReadKey();
        }
    }
}
