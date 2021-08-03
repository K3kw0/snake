using System;

namespace lesson_2
{
    class Program
    {

        // 4. Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
        // только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) 
        // подставляйте переменные, которые были заранее заготовлены до вывода на консоль.



        static void Main(string[] args)
        {
            Console.Write("Введите кол-во товара --> ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Введите цену --> ");
            double Price = double.Parse(Console.ReadLine());
            double PriceItem = Price * quantity;
            Console.Write("Введите кол-во бонусов (в р.) --> ");
            double Bonus = double.Parse(Console.ReadLine());
            double FinalPrice = PriceItem - Bonus;
            double NDS = 686.44;
            Console.Clear();
            Console.WriteLine($"Касса № 1 Смена 118 {DateTime.Now}");
            Console.WriteLine($"\nКАССОВЫЙ ЧЕК № 754\nКАССИР: ...\n ... Арт. 1234  \t{quantity} * {Price} = {PriceItem}\nОплата бонусами  \t{Bonus}\nИтоговая цена   \t{FinalPrice}\nНДС 18%           \t{NDS}");
            Console.WriteLine(new string ('-',60));
            Console.WriteLine($"ИТОГО к оплате с учётом бонусов   \t{FinalPrice}\nНаличными                              \t{FinalPrice}\nНДС 18%                          \t{NDS}");
        }
    }
}
