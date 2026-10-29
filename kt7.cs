using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main(string[] args)
        {

            Point p1 = new Point(10, 20);
            Console.WriteLine($"Точка находится в координатах X={p1.X}, Y={p1.Y}");
            Console.WriteLine($"Расстояние между точками: {Math.Abs(p1.X - p1.Y)}");

            Rectangle r1 = new Rectangle(10, 20);
            Console.WriteLine($"Площадь прямоугольника: {r1.W * r1.H}");
            Console.WriteLine($"Периметр прямоугольника: {(r1.W + r1.H) * 2}");

            Book b1 = new Book("W Book", "NN", 2031);
            Console.WriteLine($"{b1.Title} - {b1.Author}({b1.Year})");




            Console.ReadKey();
        }

        public struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public struct Rectangle
        {
            public int W;
            public int H;

            public Rectangle(int w, int h)
            {
                W = w;
                H = h;
            }
        }

        public struct Book
        {
            public string Title;
            public string Author;
            public int Year;

            public Book(string Title, string Author, int Year)
            {
                this.Title = Title;
                this.Author = Author;
                this.Year = Year;
            }
        }


        public struct rgb
        {
            public int red;
            public int green;
            public int blue;

            public rgb(int red, int green, int blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }

            public string ToHex()
            {
                return $"{red}{red}{green}{green}{blue}{blue}";
            }
        }

        public struct SimpleDate
        {
            public int Day;
            public int Month;
            public int Year;

            public SimpleDate(int Day, int Month, int Year)
            {
                this.Day = Day;
                this.Month = Month;
                this.Year = Year;
            }

            public string IsLeapYear()
            {
                if (Year % 4 == 0)
                {
                    return $"Год високосный";
                }
                else
                {
                    return $"Год не високосный";
                }
            }
        }


        public struct ComplexNumber
        {
            public int Real;
            public int Imag;

            public ComplexNumber(int Real, int Imag)
            {
                this.Real = Real;
                this.Imag = Imag;
            }

            public string Sum(int Real1, int Real2, int Imag1, int Imag2)
            {
                return $"{Real1+Real2}+{Imag1+Imag2}i";
            }

            public string Minus(int Real1, int Real2, int Imag1, int Imag2)
            {
                return $"{Real1 - Real2}+{Imag1 - Imag2}i";
            }

            public string Umn(int Real1, int Real2, int Imag1, int Imag2)
            {
                return $"{Real1 * Real2}+{Imag1 * Imag2}i";
            }

            public string Del(int Real1, int Real2, int Imag1, int Imag2)
            {
                return $"{Real1 / Real2}+{Imag1 / Imag2}i";
            }
        }

    }
}
