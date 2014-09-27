using System;

namespace GSMProject
{
    class GSMTest
    {
        public static void PrintTestResults()
        {
            GSM[] telephones = new GSM[2];

            telephones[0] = new GSM("Xperia X8", "Sony", 400m, "Nikolay", new Battery("Unknown"), new Display(2));
            telephones[1] = new GSM("iPhone", "Sony Ericsson", 1600m, "Nikolay", new Battery("Dam"), new Display(4));

            for (int i = 0; i < telephones.Length; i++)
            {
                Console.WriteLine("Telephone {0}: {1}", i + 1, telephones[i]);
            }

            Console.WriteLine("iPhone: {0}", GSM.IPhone4S);
        }
    }
}
