using System;

namespace lesson_2
{
    class Program
    {

        // 5. (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».


        static void Main(string[] args)
        {

            Console.Write("Введите месяц --> ");
            string month = Console.ReadLine();
            Console.Write("Введите приблезительную среднюю температуру --> ");
            int t = int.Parse(Console.ReadLine());
            switch (month)
            {
                case "январь": Winter(t); break;
                case "февраль": Winter(t); break;
                case "март": Spring(t); break;
                case "апрель": Spring(t); break;
                case "май": Spring(t); break;
                case "июнь": Summer(t); break;
                case "июль": Summer(t); break;
                case "август": Summer(t); break;
                case "сентябрь": Autumn(t); break;
                case "октябрь": Autumn(t); break;
                case "ноябрь": Autumn(t); break;
                case "декабрь": Winter(t); break;
                default: Console.WriteLine("Error"); break;
            }
        }
        static void Winter(int t)
        {
            if (t > 0) Console.WriteLine("Дождливая зима");
            else Console.WriteLine("Снежная зима");
        }

        static void Spring(int t)
        {
            if (t > 6) Console.WriteLine("Тёплая весна");
            else Console.WriteLine("Холодная весна");
        }
        static void Summer(int t)
        {
            if (t > 10) Console.WriteLine("Жаркое лето");
            else Console.WriteLine("Холодное лето");
        }
        static void Autumn(int t)
        {
            if (t > 0) Console.WriteLine("Тёплая осень");
            else Console.WriteLine("Холодная осень");
        }
    }
}
