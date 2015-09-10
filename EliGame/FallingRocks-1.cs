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
        int width = 100; 
        int height = 50;  
        Console.SetWindowSize(width, height);
        Console.SetCursorPosition(0, 0);
        int ColX = width/2;
        int RowY = height;
        

        Random x = new Random();
        Random y = new Random();

        int x1 = x.Next(0, 100);
        int y1 = y.Next(0, 10);
        int y11 = 0;

        int x2 = x.Next(0, 100);
        int y2 = y.Next(0, 10);
        int y22 = 0;

        int x3 = x.Next(0, 100);
        int y3 = y.Next(0, 10);
        int y33 = 0;

        int x4 = x.Next(0, 100);
        int y4 = y.Next(0, 10);
        int y44 = 0;

        int x5 = x.Next(0, 100);
        int y5 = y.Next(0, 10);
        int y55 = 0;

        int x6 = x.Next(0, 100);
        int y6 = y.Next(0, 10);
        int y66 = 0;

        int x7 = x.Next(0, 100);
        int y7 = y.Next(0, 10);
        int y77 = 0;

        int x8 = x.Next(0, 100);
        int y8 = y.Next(0, 10);
        int y88 = 0;

        int x9 = x.Next(0, 100);
        int y9 = y.Next(0, 10);
        int y99 = 0;

        int x10 = x.Next(0, 100);
        int y10 = y.Next(0, 10);
        int y1010 = 0;

        int x11 = x.Next(0, 100);
        int y112 = y.Next(0, 10);
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
            Console.SetCursorPosition(ColX, RowY);
            Console.Write("(0)");

            if (Console.KeyAvailable == true)
            {
                ConsoleKeyInfo dwarf = Console.ReadKey();
                switch (dwarf.KeyChar)
                {
                    case 'f': Console.SetCursorPosition((ColX + 3), RowY);
                        Console.Write("(0)");
                        break;
                    case 's': Console.SetCursorPosition((ColX - 3), RowY);
                        Console.Write("(0)");
                        break;
                }

                RowY = Console.CursorTop;
                ColX = Console.CursorLeft-3;
            }
            else
            {
                RowY = Console.CursorTop;
                ColX = Console.CursorLeft-3;
            }
                                   
            if (j <= 50-y1 )
            {
           
                Console.SetCursorPosition(x1, y1+j);
                Console.Write("^");
                y11 = y1 + j;
                j++;
                
            }
            else
            {
                if (x1 == ColX && y11 == RowY)
                {
                   goto finish;
                }
                x1 = x.Next(0, 100);
                j = 0;
            }
            if (k <= 50-y2)
            {
                Console.SetCursorPosition(x2, y2 + k);
                Console.Write("@");
                y22 = y2 + k;
                k++;
                
            }
            else
            {
                if (x2 == ColX && y22 == RowY)
                {
                    goto finish;
                }
                x2 = x.Next(0, 100);
                k = 0;
            }
            if (l <= 50-y3)
            {
                Console.SetCursorPosition(x3, y3 + l);
                Console.Write("*");
                y33 = y3 + l;
                l++;
                
            }
            else
            {
                if (x3 == ColX && y33 == RowY)
                {
                    goto finish;
                }
                x3 = x.Next(0, 100);
                l = 0;
            }
            if (m <= 50 - y4)
            {
                Console.SetCursorPosition(x4, y4 + m);
                Console.Write("&");
                y44 = y4 + m;
                m++;

            }
            else
            {
                if (x4 == ColX && y44 == RowY)
                {
                    goto finish;
                }
                x4 = x.Next(0, 100);
                m = 0;
            }
            if (n <= 50 - y5)
            {
                Console.SetCursorPosition(x5, y5 + n);
                Console.Write("+");
                y55 = y5 + n;
                n++;

            }
            else
            {
                if (x5 == ColX && y55 == RowY)
                {
                    goto finish;
                }
                x5 = x.Next(0, 100);
                n = 0;
            }
            if (o <= 50 - y6)
            {
                Console.SetCursorPosition(x6, y6 + o);
                Console.Write("%");
                y66 = y6 + o;
                o++;

            }
            else
            {
                if (x6 == ColX && y66 == RowY)
                {
                    goto finish;
                }
                x6 = x.Next(0, 100);
                o = 0;
            }
            if (p <= 50 -y7 )
            {
                Console.SetCursorPosition(x7, y7 + p);
                Console.Write("$");
                y77 = y7 + p;
                p++;

            }
            else
            {
                if (x7 == ColX && y77 == RowY)
                {
                    goto finish;
                }
                x7 = x.Next(0, 100);
                p = 0;
            }
            if (q <= 50 - y8)
            {
                Console.SetCursorPosition(x8, y8 + q);
                Console.Write("#");
                y88 = y8 + q;
                q++;

            }
            else
            {
                if (x8 == ColX && y88 == RowY)
                {
                    goto finish;
                }
                x8 = x.Next(0, 100);
                q = 0;
            }

            if (r <= 50 - y9)
            {
                Console.SetCursorPosition(x9, y9 + r);
                Console.Write("!");
                y99 = y9 + r;
                r++;

            }
            else
            {
                if (x9 == ColX && y99 == RowY)
                {
                    goto finish;
                }
                x9 = x.Next(0, 100);
                r = 0;
            }
            if (s <= 50 - y10)
            {
                Console.SetCursorPosition(x10, y10 + s);
                Console.Write(".");
                y1010 = y10 + s;
                s++;

            }
            else
            {
                if (x10 == ColX && y1010 == RowY)
                {
                    goto finish;
                }
                x10 = x.Next(0, 100);
                s = 0;
            }
            if (t <= 50 - y112)
            {
                Console.SetCursorPosition(x11, y112 + t);
                Console.Write(";");
                y1111 = y112 + t;
                t++;

            }
            else
            {
                if (x11 == ColX && y1111 == RowY)
                {
                    goto finish;
                }
                x11 = x.Next(0, 100);
                t = 0;
            }

            Thread.Sleep(150);
            Console.Clear();
              
        }
    finish:
        Console.WriteLine("You are dead");
    }
}
        
        
    

