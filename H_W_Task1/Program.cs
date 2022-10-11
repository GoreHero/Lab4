using System;

namespace H_W_Task1
{
    internal class Program
    {
        /*For. Ввести целое число N > 0.Найти квадрат данного числа, используя для его вычисления следующую формулу:
        N2 = 1 + 3 + 5 + ... +(2 * N – 1). После добавления к сумме каждого слагаемого выводить текущее 
        значение суммы(в результате будут выведены квадраты всех целых чисел от 1 до N).*/

        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int numV2 = 1;
            int sum = 0;

            for (int i = 1; i <= num; i += 1)
            {
                if (i<num)
                {
                    numV2 = 2 * i - 1;
                    sum += numV2;
                    Console.WriteLine("Промежуток: {0}", sum);
                }
                else
                {
                    numV2 = 2 * i - 1;
                    sum += numV2;
                    Console.WriteLine("Ответ: {0} ", sum);
                }                
            }
            Console.WriteLine("Проверка: {0}", num * num);
            Console.ReadKey();
        }
    }
}
