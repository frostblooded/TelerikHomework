using System.Collections.Generic;
using System.Media;

namespace AnimalSystem
{
    internal class AnimalSystem
    {
        private static void Main()
        {
            var animals = new List<Animal>
            {
                new Dog("Darin", 7, Sex.Male),
                new Tomcat("Charlie", 2),
                new Dog("Nero", 1, Sex.Male),
                new Frog("Da", 15, Sex.Female),
                new Kitten("Maq", 20),
                new Frog("Gojo", 9, Sex.Female),
                new Dog("Rino", 8, Sex.Male),
                new Tomcat("Mila", 6),
                new Kitten("Treta", 3)
            };

            Animal.PrintAverageAge(animals);

            new Tomcat("da", 3).MakeSound();
            new Kitten("da", 3).MakeSound();
            new Frog("ne", 4, Sex.Female).MakeSound();
            new Dog("hristo", 3, Sex.Male).MakeSound();
        }
    }
}