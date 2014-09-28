using System;
using System.Text;

namespace SubstringExtensionMain
{
    class SubstringExtensionMain
    {
        static void Main()
        {
            string someString = "SomeRandomString";
            Console.WriteLine(someString.Substring(5, 7));
            StringBuilder stringBuilder = new StringBuilder("SomeRandomString");
            Console.WriteLine(stringBuilder.Substring(5, 7));
        }
    }
}
