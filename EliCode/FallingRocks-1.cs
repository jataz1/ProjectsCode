using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Threading;


class FallingRocks
{
    static void Main()
    {
        int width = 70;
        int height = 35;
        Console.SetWindowSize(width, height);
        Console.SetBufferSize(width + 10, height + 10);
        int ColX = width / 2;
        int RowY = height;


        Random x = new Random();
        Random y = new Random();

        int x1 = x.Next(0, width);
        int y1 = y.Next(0, height - 10);
        int y11 = 0;

        int x2 = x.Next(0, width);
        int y2 = y.Next(0, height - 10);
        int y22 = 0;

        int x3 = x.Next(0, width);
        int y3 = y.Next(0, height - 10);
        int y33 = 0;

        int x4 = x.Next(0, width);
        int y4 = y.Next(0, height - 10);
        int y44 = 0;

        int x5 = x.Next(0, width);
        int y5 = y.Next(0, height - 10);
        int y55 = 0;

        int x6 = x.Next(0, width);
        int y6 = y.Next(0, height - 10);
        int y66 = 0;

        int x7 = x.Next(0, width);
        int y7 = y.Next(0, height - 10);
        int y77 = 0;

        int x8 = x.Next(0, width);
        int y8 = y.Next(0, height - 10);
        int y88 = 0;

        int x9 = x.Next(0, width);
        int y9 = y.Next(0, height - 10);
        int y99 = 0;

        int x10 = x.Next(0, width);
        int y10 = y.Next(0, height - 10);
        int y1010 = 0;

        int x11 = x.Next(0, width);
        int y112 = y.Next(0, height - 10);
        int y1111 = 0;

        int j = 0;
        int k = 0;
        int l = 0;
        int m = 0;
        int n = 0;
        int o = 0;
        int p = 0;
        int q = 0;
        int r = 0;
        int s = 0;
        int t = 0;

        for (int i = 0; i < 500; i++)
        {
            Console.CursorSize = 100;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(ColX, RowY);
            Console.Write("(0)");

            if (Console.KeyAvailable == true)
            {
                ConsoleKeyInfo dwarf = Console.ReadKey();
                switch (dwarf.KeyChar)
                {
                    case 'f':
                        Console.SetCursorPosition((ColX + 3), RowY);
                        Console.CursorSize = 100;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("(0)");
                        if (ColX == 68)
                        {
                            Console.SetCursorPosition(width / 2, height);
                            Console.CursorSize = 100;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("(0)");
                        }
                        break;

                    case 's':
                        Console.SetCursorPosition((ColX - 3), RowY);
                        Console.CursorSize = 100;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("(0)");
                        if (ColX == 5)
                        {
                            Console.SetCursorPosition(width / 2, height);
                            Console.CursorSize = 100;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("(0)");
                        }
                        break;
                }

                RowY = Console.CursorTop;
                ColX = Console.CursorLeft - 3;
            }
            else
            {
                RowY = Console.CursorTop;
                ColX = Console.CursorLeft - 3;
            }

            if (j <= height - y1)
            {
                Console.SetCursorPosition(x1, y1 + j);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("^");
                y11 = y1 + j;
                j++;

            }
            else
            {
                if (x1 == ColX && y11 == RowY || x1 == ColX + 1 && y11 == RowY || x1 == ColX + 2 && y11 == RowY)
                {
                    goto finish;
                }
                x1 = x.Next(0, width);
                j = 0;
            }
            if (k <= height - y2)
            {
                Console.SetCursorPosition(x2, y2 + k);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");
                y22 = y2 + k;
                k++;

            }
            else
            {
                if (x2 == ColX && y22 == RowY || x2 == ColX + 1 && y22 == RowY || x2 == ColX + 2 && y22 == RowY)
                {
                    goto finish;
                }
                x2 = x.Next(0, width);
                k = 0;
            }
            if (l <= height - y3)
            {
                Console.SetCursorPosition(x3, y3 + l);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("*");
                y33 = y3 + l;
                l++;

            }
            else
            {
                if (x3 == ColX && y33 == RowY || x3 == ColX + 1 && y33 == RowY || x3 == ColX + 2 && y33 == RowY)
                {
                    goto finish;
                }
                x3 = x.Next(0, width);
                l = 0;
            }
            if (m <= height - y4)
            {
                Console.SetCursorPosition(x4, y4 + m);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("&");
                y44 = y4 + m;
                m++;

            }
            else
            {
                if (x4 == ColX && y44 == RowY || x4 == ColX + 1 && y44 == RowY || x4 == ColX + 2 && y44 == RowY)
                {
                    goto finish;
                }
                x4 = x.Next(0, width);
                m = 0;
            }
            if (n <= height - y5)
            {
                Console.SetCursorPosition(x5, y5 + n);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("+");
                y55 = y5 + n;
                n++;

            }
            else
            {
                if (x5 == ColX && y55 == RowY || x5 == ColX + 1 && y55 == RowY || x5 == ColX + 2 && y55 == RowY)
                {
                    goto finish;
                }
                x5 = x.Next(0, width);
                n = 0;
            }
            if (o <= height - y6)
            {
                Console.SetCursorPosition(x6, y6 + o);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("%");
                y66 = y6 + o;
                o++;

            }
            else
            {
                if (x6 == ColX && y66 == RowY || x6 == ColX + 1 && y66 == RowY || x6 == ColX + 2 && y66 == RowY)
                {
                    goto finish;
                }
                x6 = x.Next(0, width);
                o = 0;
            }
            if (p <= height - y7)
            {
                Console.SetCursorPosition(x7, y7 + p);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("$");
                y77 = y7 + p;
                p++;

            }
            else
            {
                if (x7 == ColX && y77 == RowY || x7 == ColX + 1 && y77 == RowY || x7 == ColX + 2 && y77 == RowY)
                {
                    goto finish;
                }
                x7 = x.Next(0, width);
                p = 0;
            }
            if (q <= height - y8)
            {
                Console.SetCursorPosition(x8, y8 + q);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                y88 = y8 + q;
                q++;

            }
            else
            {
                if (x8 == ColX && y88 == RowY || x8 == ColX + 1 && y88 == RowY || x8 == ColX + 2 && y88 == RowY)
                {
                    goto finish;
                }
                x8 = x.Next(0, width);
                q = 0;
            }

            if (r <= height - y9)
            {
                Console.SetCursorPosition(x9, y9 + r);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("!");
                y99 = y9 + r;
                r++;

            }
            else
            {
                if (x9 == ColX && y99 == RowY || x9 == ColX + 1 && y99 == RowY || x9 == ColX + 2 && y99 == RowY)
                {
                    goto finish;
                }
                x9 = x.Next(0, width);
                r = 0;
            }
            if (s <= height - y10)
            {
                Console.SetCursorPosition(x10, y10 + s);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(".");
                y1010 = y10 + s;
                s++;

            }
            else
            {
                if (x10 == ColX && y1010 == RowY || x10 == ColX + 1 && y1010 == RowY || x10 == ColX + 2 && y1010 == RowY)
                {
                    goto finish;
                }
                x10 = x.Next(0, width);
                s = 0;
            }
            if (t <= height - y112)
            {
                Console.SetCursorPosition(x11, y112 + t);
                Console.CursorSize = 50;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(";");
                y1111 = y112 + t;
                t++;

            }
            else
            {
                if (x11 == ColX && y1111 == RowY || x11 == ColX + 1 && y1111 == RowY || x11 == ColX + 2 && y1111 == RowY)
                {
                    goto finish;
                }
                x11 = x.Next(0, width);
                t = 0;
            }

            Thread.Sleep(150);
            Console.Clear();

        }
    finish:
        Console.Clear();
        Console.SetCursorPosition(width / 2, height / 2);
        Console.CursorSize = 100;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("YOU ARE DEAD!!!!");
        Console.ResetColor();
    }
}




