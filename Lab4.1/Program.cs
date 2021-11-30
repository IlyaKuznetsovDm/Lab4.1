using System;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //4.1- 8 вариант - базовый уровень
            double[] m = new double[16];
            Random rnd = new Random();
            Console.WriteLine("Вывод - 16 элементов массива: ");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = rnd.Next(16);
                Console.WriteLine(m[i] + " ");

            }
            double min = m[0];
            double max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                {
                    max = m[i];
                }
                if (min > m[i])
                {
                    min = m[i]; 
                }
            }          
            Console.WriteLine("------------------------------");
            Console.WriteLine("Результат:");           
            Console.WriteLine("Мин.элемент = {0} ", min);
            Console.WriteLine("Макс.элемент = {0} ", max);
            Console.WriteLine("------------------------------");
        }
    }
}
