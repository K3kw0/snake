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
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }

    class Figure
    {
        protected List<Point> pList;
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }

    class HorizontileLine : Figure
    {
        public HorizontileLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class VerticleLine : Figure
    {
        public VerticleLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            HorizontileLine upLine = new HorizontileLine(0, 78, 0, '+');
            HorizontileLine downLine = new HorizontileLine(0, 78, 24, '+');
            VerticleLine leftLine = new VerticleLine(0, 24, 0, '+');
            VerticleLine righttLine = new VerticleLine(0, 24, 78, '+');
            Point p = new Point(4, 5, '*');
            p.Draw();

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righttLine.Drow();

            
        }
    }
}
