using System;

namespace Practikal_3_10_3_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число :\n");
            int i;
            i = int.Parse(Console.ReadLine());
            int j = 2;
            bool flag = true;
            while (j < i)
            {
                if (i % j == 0)
                {
                    flag = false;
                }
                j++;
            }
            if (flag == true)
            {
                Console.WriteLine(" Число является простым.");
            }
            else
            {
                Console.WriteLine(" Число является сложным.");
            }
        }
    }
}
