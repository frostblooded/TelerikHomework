﻿using System;

class RandomValues
{
    static void Main()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(100, 201));
        }
    }
}

