using System;

namespace lesson_2
{
    class Program
    {
        // Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру, чтобы описать работу какого либо офиса.
        // Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.


        static void Main(string[] args)
        {
            Days week = (Days)0b_1111111;
            Console.WriteLine($"Рабочие дни --> {week}");
            Days TuesdayFriday = Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Saturday;
            Days MondaySunday = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday | Days.Saturday | Days.Sunday;
            Console.Write("Введите номер офиса --> ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine($"Рабочие дни первого офиса --> {TuesdayFriday}"); break;
                case 2: Console.WriteLine($"Рабочие дни второго офиса --> {MondaySunday}"); break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
    [Flags]
    public enum Days
    {
        Monday = 0b_0000001,
        Tuesday = 0b_0000010,
        Wednesday = 0b_0000100,
        Thursday = 0b_0001000,
        Friday = 0b_0010000,
        Saturday = 0b_0100000,
        Sunday = 0b_1000000,
    }
}
