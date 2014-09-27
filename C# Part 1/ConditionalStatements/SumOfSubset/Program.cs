using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input value of number {0}", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (a[i] == 0)
                {
                    Console.WriteLine("{0} = 0", a[i]);
                }
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] + a[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", a[i], a[j]);
                    }
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", a[i], a[j], a[k]);
                        }
                        for (int z = k + 1; z < 5; z++)
                        {
                            if (a[i] + a[j] + a[k] + a[z] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a[i], a[j], a[k], a[z]);
                            }
                        }
                    }
                }
            }
            if (a[0] + a[1] + a[2] + a[3] + a[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a[0], a[1], a[2], a[3], a[4]);
            }
        }
    }
}
