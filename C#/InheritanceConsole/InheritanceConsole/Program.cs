using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsole
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            //method
            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happinsee: " + happiness);
            }
        }

        //dog class share all the base value/field with animal class
        class Dog : Animal
        {
            public int spotCount;
            public void Bark()
            {
                Console.WriteLine("WUF!");
            }
        }

        class Cat : Animal
        {
            public float cuteness;
            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }

        public static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();

            Console.ReadKey();
        }
    }
}
