using System;

namespace lesson_2
{
    class Program
    {

        // 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки --> ");
            double t1 = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки --> ");
            double t2 = double.Parse(Console.ReadLine());
            double average = (t1 + t2) / 2;
            Console.WriteLine($"Среднесуточная температура составляет --> {average:f2}");
        }
    }
}
