using System;

class Program
{
    static void Main()
    {
        //Letters array initialization
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 97);
        }

        //Input
        Console.WriteLine("Input a word.");
        string usedWord = Console.ReadLine();

        //Solution
        for (int i = 0; i < usedWord.Length; i++)
        {
            bool found = false;
            int l = 0, r = letters.Length, m;
            do
            {
                m = (l + r) / 2;
                if (letters[m] == usedWord[i])
                {
                    Console.WriteLine("{0} = {1}", usedWord[i], m);
                    found = true;
                }
                else if (letters[m] < usedWord[i])
                {
                    l = m + 1;
                }
                else if (letters[m] > usedWord[i])
                {
                    r = m - 1;
                }
            } while (!found);
        }
    }
}    
