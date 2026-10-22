using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 500;
            string s = "Hello World";
            Box<int> int_box = new Box<int>();
            Box<string> string_box = new Box<string>();
            int_box.Set(ref x);
            string_box.Set(ref s);
            int_box.Get();
            string_box.Get();

            int x1 = 5, y = 10;
            Utils.Swap(ref x1, ref y); 

            string s1 = "Hello", s2 = "World";
            Utils.Swap(ref s1, ref s2);

            Console.WriteLine($"Числа после Swap: {x1}, {y}");
            Console.WriteLine($"Строки после Swap: {s1}, {s2}");

            Pair<int, string> p = new Pair<int, string>();
            p.First = 5;
            p.Second = "Hello";
            Console.WriteLine($"Первое значение: {p.First}, Второе значение: {p.Second}");


            Console.ReadKey();
        }

        class Box<T>
        {
            private T _value;

            public void Get()
            {
                Console.WriteLine($"В коробке : {_value}, с типом {typeof(T).Name}");
            }

            public void Set(ref T value)
            {
                _value = value;
                Console.WriteLine($"Вы положили : {_value}");
            }
        }

        class Utils
        {
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

        class Pair<T1, T2>
        {
            public T1 First;
            public T2 Second;
        }
    }
}
