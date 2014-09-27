using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Length of the arrays?");
        int length = int.Parse(Console.ReadLine());
        char[] firstCharacter = new char[length];
        char[] secondCharacters = new char[length];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Element {0} of the first array?", i + 1);
            firstCharacter[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Element {0} of the second array?", i + 1);
            secondCharacters[i] = char.Parse(Console.ReadLine());
        }
        bool same = true;
        int j = 0;
        do
        {
            if (firstCharacter[j] != secondCharacters[j])
            {
                same = false;
            }
            j++;
        } while (same && j < length);
        string result = same ? "They are the same" : "They are different";
        Console.WriteLine(result);
    }
}
