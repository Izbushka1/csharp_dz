using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            
            fixed (int* p = numbers)
            {
                Console.Write("До: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{*(p + i)} ");
                }

                Console.WriteLine();
                Console.Write("После: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{(*(p + i)) + 10} ");
                }
                Console.WriteLine("\n\n");
            }

            int x = 50;
            int* ptr = &x;
            int** pp = &ptr;

            
            Console.WriteLine($"Адрес х: {(ulong)&x}");
            Console.WriteLine($"Адрес ptr: {(ulong)ptr}");
            Console.WriteLine($"Значение x до: {x}");
            **pp = 999;
            Console.WriteLine($"Значение x после изменения через **pp: {x}");

            Console.ReadKey();
        }

            
    }
}
