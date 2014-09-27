using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("One side and altitude to it, three sides or two sides and an angle between them? (1, 2, 3)");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        double surface = 1;
        switch(choice)
        {
            //One side and an altitude to it
            case 1:
                Console.WriteLine("What is the length of the side? (metres)");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the altitude? (metres)");
                int altitude = int.Parse(Console.ReadLine());
                surface = (side * altitude) / (double)2;
                break;

            //Three sides
            case 2:
                int[] sides = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("What is the length of side {0}?", i + 1);
                    sides[i] = int.Parse(Console.ReadLine());
                }
                double semiPerimeter = 0;
                for (int i = 0; i < 3; i++)
                {
                    semiPerimeter += sides[i];
                }
                semiPerimeter /= 2;
                surface = Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
                break;

            //Two sides and an angle between them
            case 3:
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("What is the length of side {0}", i + 1);
                    surface *= int.Parse(Console.ReadLine());
                }
                Console.WriteLine("How much degrees is the angle between them?");
                surface *= Math.Sin(int.Parse(Console.ReadLine()));
                break;
        }

        //Output
        Console.WriteLine("The surface of the triangle is {0: 0.00}", surface);
    }
}