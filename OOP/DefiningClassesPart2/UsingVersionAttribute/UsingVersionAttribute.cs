using System;
using System.Reflection;

namespace UsingVersionAttribute
{
    class UsingVersionAttribute
    {
        static void Main()
        {
            var properties = typeof(SampleClass).GetProperties();

            Console.WriteLine("Properties versions:");
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes<VersionAttribute>();

                foreach (var attribute in attributes)
                {
                    Console.WriteLine("{0} - {1}", property, attribute.Version);
                }
            }

            var attributesOfClasses = typeof(SampleClass).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in attributesOfClasses)
            {
                Console.WriteLine("Sample Class Version - {0}", attribute.Version);
            }
        }
    }
}
