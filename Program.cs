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
            Animals cat = new Animals("cotost", 3, "snejok", "mew");
            cat.getInfo();
            Console.ReadLine();
        }


        class Animals
        {
            private string Type;
            private int Age;
            private string Name;
            private string Sound;


            public Animals()
            {
                Type = "";
                Age = 0;
                Name = "";
                Sound = "";
            }

            public Animals(string type, int age, string name, string sound)
            {
                Type = type;
                Age = age;
                Name = name;
                Sound = sound;
            }


            public string type
            {
                get { return Type; }
                set
                {
                    if (value == null || value == "")
                    {
                        Console.WriteLine("enter a type");
                    }
                    else Type = value;
                }
            }

            public int age
            {
                get { return Age; }
                set
                {
                    if (value <= 0 || value == null || value >= 50)
                    {
                        Console.WriteLine("enter a valid age");
                    }
                    else Age = value;
                }
            }

            public string name
            {
                get { return Name; }
                set
                {
                    if (value == null || value == "")
                    {
                        Console.WriteLine("enter a name");
                    }
                    else Name = value;
                }
            }

            public string sound
            {
                get { return Sound; }           
                set
                {
                    if (value == null || value == "")
                    {
                        Console.WriteLine("enter a sound");
                    }
                    else Sound = value;
                }
            }

            public void getInfo()
            {
                Console.WriteLine($"Вид: {type}\nВозраст: {age}\nКличка: {name}\nЗвук: {sound}");
            }

        }
    }
}
