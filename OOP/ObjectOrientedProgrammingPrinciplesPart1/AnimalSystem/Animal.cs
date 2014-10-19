using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;

namespace AnimalSystem
{
    internal abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; private set; }

        protected Animal()
        {
            Name = "Unknown";
            Age = 0;
            Sex = Sex.Male;
        }

        protected Animal(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public static void PrintAverageAge(IEnumerable<Animal> animals)
        {
            int dogAverageAge = 0;
            int dogCount = 0;
            int tomCatAverageAge = 0;
            int tomCatCount = 0;
            int kittenAverageAge = 0;
            int kittenCount = 0;
            int frogAverageAge = 0;
            int frogCount = 0;


            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    dogAverageAge += animal.Age;
                    dogCount++;
                }
                else if (animal is Frog)
                {
                    frogAverageAge += animal.Age;
                    frogCount++;
                }
                else if (animal is Kitten)
                {
                    kittenAverageAge += animal.Age;
                    kittenCount++;
                }
                else if (animal is Tomcat)
                {
                    tomCatAverageAge += animal.Age;
                    tomCatCount++;
                }
            }

            dogAverageAge /= dogCount;
            frogAverageAge /= frogCount;
            kittenAverageAge /= kittenCount;
            tomCatAverageAge /= tomCatCount;

            Console.WriteLine("The average ages of the animals are:");
            Console.WriteLine("Dog: " + dogAverageAge);
            Console.WriteLine("Frog: " + frogAverageAge);
            Console.WriteLine("Kitten: " + kittenAverageAge);
            Console.WriteLine("Tomcat: " + tomCatAverageAge);
        }

        protected static void MakeSound(string file)
        {
            var soundPlayer = new SoundPlayer(file);
            soundPlayer.Play();
            Thread.Sleep(2000);
        }
    }
}