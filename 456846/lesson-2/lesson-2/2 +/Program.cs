using System;

namespace lesson_2
{
    class Program
    {
        //  2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.

        static string q(string[] a, int month)
        {
            string m = "";
            Console.Write("Нынешний месяц --> ");
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + 1) == month) m = a[i];
            }
            return m;
        }
        static void Main(string[] args)
        {

            //  1 вариант

            Console.Write("Введите номер текущего месяца --> ");
            int month = int.Parse(Console.ReadLine());
            string[] a = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine(q(a, month));

            //  2 вариант

            switch (month)
            {
                case 1: Console.WriteLine(q(a, month)); break;
                case 2: Console.WriteLine(q(a, month)); break;
                case 3: Console.WriteLine(q(a, month)); break;
                case 4: Console.WriteLine(q(a, month)); break;
                case 5: Console.WriteLine(q(a, month)); break;
                case 6: Console.WriteLine(q(a, month)); break;
                case 7: Console.WriteLine(q(a, month)); break;
                case 8: Console.WriteLine(q(a, month)); break;
                case 9: Console.WriteLine(q(a, month)); break;
                case 10: Console.WriteLine(q(a, month)); break;
                case 11: Console.WriteLine(q(a, month)); break;
                case 12: Console.WriteLine(q(a, month)); break;
                default: Console.WriteLine("Такого месяца нету"); break;
            }
        }
    }
}