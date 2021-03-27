using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
namespace пральный_проект
{

    class Point
    {
        public int x;
        public int y;
        public char sym;
        public void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Draw(1, 3, '*');

            Point p2 = new Point();
            p2.Draw(4, 5, '#');
        }
    }
}
