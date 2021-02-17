using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число 2:");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.Write($"{a}<{b}");

            }
            else if (a>b) {
                Console.Write($"{a}>{b}");
            }
            else {
                Console.Write($"{a}={b}");
            }
        }
    }
}
