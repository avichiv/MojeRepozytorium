using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////console.writeline(10 + 13);
            ////////console.readkey();
            ////////int a = 5;
            //int b = 3;
            //int c = a + b;
            //int d = a - b;
            //int e = a * b;
            //float f = a / 5;
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //double liczba = 1.345;
            //float liczba = 1.345f;
            //float a = 4;
            //float b = 0;
            //Console.WriteLine(a / b);
            
            //double liczba1 = 1.234;
            //double liczba2 = 1.234f;
            //double liczba3 = 1.234d;
            //Console.WriteLine(liczba1);
            //Console.WriteLine(liczba2);
            //Console.WriteLine(liczba3);

            //float liczba4 = 1.234f;
            //float liczba5 = 1.234f;
            //float liczba6 = 1.234f;
            //Console.WriteLine(liczba1);
            //Console.WriteLine(liczba2);
            //Console.WriteLine(liczba3);

            //bool prawda = true;
            //int zmienna = 5;
            //Console.WriteLine(prawda);
            //Console.WriteLine(!prawda);
            //Console.WriteLine(true & false);
            //Console.WriteLine(true | false);
            //Console.WriteLine(5 < 2);
            //Console.WriteLine(5 > 2);
            //Console.WriteLine(zmienna == 2);
            //Console.WriteLine(zmienna = 2);
            //Console.WriteLine(5 != 2);

            //int a = 5;
            //int b = 9;
            //int c = 11;
            //Console.WriteLine(a / b);
            //Console.WriteLine(a / c);
            //Console.WriteLine(b / c);
            //Console.WriteLine(b / a);
            //Console.WriteLine(c / a);
            //Console.WriteLine(c / b);

            //int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Math.Max(Math.Max(a,b),c));
            //Console.WriteLine(Math.Min(Math.Min(a,b),c));

            //int[] tab = new int[] { a, b, c };
            //Console.WriteLine("Max: {0}\nMin:{1}", tab.Max(), tab.Min());
            
            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;
            
            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;

            //Console.WriteLine("Max = {0}, Min = {1}", max, min);

            /*1*/
            //int x = 1, y;
            /*2*/
            //console.writeline(++x);
            /*3*/
            //console.writeline(x++);
            /*4*/
            //console.writeline(x);
            /*5*/
            //y = x++;
            /*6*/
            //console.writeline(y);
            /*7*/
            //y = ++x;
            /*8*/
            //console.writeline(++y);

            //Console.WriteLine("Podaj symbol temperatury: K,C,F");
            //int numerZnaku = Console.Read();
            //char znak = (char)numerZnaku;
            //Console.ReadLine(); //wczytanie zalamania linii

            //ConsoleKeyInfo klawisz = Console.ReadKey();
            //char znak = klawisz.KeyChar;


            //Console.WriteLine(Environment.NewLine + "Podaj wartosc temperatury:");
            //double temp = Convert.ToDouble(Console.ReadLine());
            //if (znak == 'K')
            //{
            //    Console.WriteLine("Cos tam K");
            //}
            //else if (znak == 'C')
            //{
            //    Console.WriteLine("Cos tam C");
            //}
            //else if (znak == 'F')
            //{
            //    Console.WriteLine("Cos tam F");
            //}

            //int[,] tablica = new int[5,5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        tablica[i, j] = 3 * j * i + 5 * j - 2;
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i!=j)
            //        {
            //            Console.WriteLine(tablica[i, j] + "");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            int[] tab = new int[30];
            tab[0] = 0;
            tab[0] = 1;
            int n = 2;
            while (tab.Max() < 1000)
            {
                tab[n] = tab[n - 1] + tab[n - 2];
                n++;
            }

            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine(tab[i] + " ");
            }

                Console.ReadKey();
        }
    }
}
