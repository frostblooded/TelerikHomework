using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("One side and altitude to it, three sides or two sides and an angle between them? (1, 2, 3)");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        switch(choice)
        {
            //One side and an altitude to it
            case 1:
                Console.WriteLine("What is the length of the side? (metres)");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the altitude? (metres)");
                int altitude = int.Parse(Console.ReadLine());
                double surface = (side * altitude) / (double)2;
                Console.WriteLine("The surface of the triangle is {0: 0.0}", surface);
                break;
            //Three sides
            case 2:
                break;
            //Two sides and an angle between them
            case 3:
                break;
        }
    }
}