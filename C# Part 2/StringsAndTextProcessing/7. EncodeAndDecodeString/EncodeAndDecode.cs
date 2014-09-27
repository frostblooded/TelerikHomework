using System;
using System.Text;

class EncodeAndDecode
{
    static string EncodeOrDecode(string text, string key)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; )
        {
            for (int j = 0; j < key.Length && i < text.Length; j++, i++)
            {
                result.Append((char)(text[i] ^ key[j]));
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine("What is the text that you want to encode or decode?");
        string text = Console.ReadLine();
        Console.WriteLine("What is the encryption key?");
        string key = Console.ReadLine();
        Console.WriteLine(EncodeOrDecode(text, key));
    }
}