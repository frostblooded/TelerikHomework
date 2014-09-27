using System;

namespace MatrixClass
{
    class MatrixClass
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(2, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 2);

            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[0, 2] = 3;
            firstMatrix[1, 0] = 4;
            firstMatrix[1, 1] = 5;
            firstMatrix[1, 2] = 6;

            secondMatrix[0, 0] = 7;
            secondMatrix[0, 1] = 8;
            secondMatrix[1, 0] = 9;
            secondMatrix[1, 1] = 10;
            secondMatrix[2, 0] = 11;
            secondMatrix[2, 1] = 12;

            Console.WriteLine(firstMatrix * secondMatrix);
        }
    }
}
