using System;

namespace H_W_Task2
{
    internal class Program
    {
        /*Задачи на использование операторов цикла с постусловием.
         * Осуществить ввод последовательности целых чисел и сравнить,
         * что больше, количество положительных или количество отрицательных. 
         * Последовательность потенциально не ограничена, окончанием последовательности служит число 0*/

        static void Main(string[] args)
        {
            int countP = 0;
            int countM = 0;
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    countP += 1;
                else if (num < 0)
                    countM += 1;
            }
            while (num != 0);
            if (countP > countM)
                Console.WriteLine("Тут плюсов ({0}) больше чем минусов ({1})", countP, countM);
            else
                if (countP < countM)
                Console.WriteLine("Тут минусов ({0}) больше чем плюсов ({1})", countM, countP);
            else
                Console.WriteLine("Плюсов ({1}) и минусов ({0}) одинаково", countP, countM);
            Console.ReadKey();
        }
    }
}
