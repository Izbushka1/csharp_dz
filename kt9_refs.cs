using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 5, y = 10;
            Console.WriteLine($"Исходные значения: x = {x}, y = {y}\n");
            SwapWithoutRef(x, y);
            Console.WriteLine($"Внутри SwapWithoutRef: a = {y}, b = {x}");
            Console.WriteLine($"После SwapWithoutRef: x = {x}, y = {y}\n");

            Console.WriteLine($"Внутри SwapWithRef: a = {y}, b = {x}");
            SwapWithRef(ref x, ref y);
            Console.WriteLine($"После SwapWithRef: x = {x}, y = {y}");

            Person one = new Person("Алексей", 30);
            Person two = new Person("Мария", 25);

            Console.WriteLine($"Исходные данные:\nName: {one.Name}, Age: {one.Age}\nName: {two.Name}, Age: {two.Age}");
            Console.WriteLine("Попытка сброса без ref");
            ResetPersonWithoutRef(one);
            Console.WriteLine("Внутри ResetPersonWithoutRef: person установлен в null.");
            Console.WriteLine($"person1 не null: Name: {one.Name}, Age: {one.Age}\n");

            Console.WriteLine("Попытка сброса с ref");
            ResetPersonWithRef(ref two);
            Console.WriteLine("Внутри ResetPersonWithRef: person установлен в null.");

            Console.WriteLine($"person2 is null : Name: {two.Name}, Age: {two.Age};");


            Console.ReadKey();
        }

        public static void SwapWithRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapWithoutRef(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void ResetPersonWithoutRef(Person p)
        {
            p = null;
        }

        public static void ResetPersonWithRef(ref Person p)
        {
            p = null;
        }

    }
    public class Person
    {
        public string Name;
        public int? Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
