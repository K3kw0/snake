using System;

namespace lesson_2
{
    class Program
    {

        //  3. Определить, является ли введённое пользователем число чётным.


        static void Main(string[] args)
        {
            Console.Write("Введите число --> ");
            int a = int.Parse(Console.ReadLine());

            // 1 вариант
            if (a % 2 == 0) Console.WriteLine("Вы ввели чётное число");
            else Console.WriteLine("Вы ввели нечётное число");

            // 2 вариант
            string r = a % 2 == 0 ? "Вы ввели чётное число" : "Вы ввели нечётное число";
            Console.WriteLine(r);
        }
    }
}
