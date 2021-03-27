using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset , Direction direction)
        {
            if (direction == Direction.RIGHT) x += offset;
            else if(direction == Direction.LEFT) x -= offset;
            else if (direction == Direction.UP) y -= offset;
            else if (direction == Direction.DOWN) y += offset;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
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

    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN,
    }

    class Snake: Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HorizontileLine upLine = new HorizontileLine(0, 78, 0, '+');
            HorizontileLine downLine = new HorizontileLine(0, 78, 24, '+');
            VerticleLine leftLine = new VerticleLine(0, 24, 0, '+');
            VerticleLine righttLine = new VerticleLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righttLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow) snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow) snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow) snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }



           
        }
    }
}
