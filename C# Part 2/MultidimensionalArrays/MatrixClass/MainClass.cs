using System;

class MainClass
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(3, 3);
        Matrix matrix2 = new Matrix(3, 3);
        Matrix matrix3 = new Matrix(3, 3);

        //Give it some value
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                matrix2[i, j] = i + j;
                matrix3[i, j] = i + j;
            }
        }

        matrix1 = matrix2 + matrix3;

        Console.WriteLine(matrix1.ToString());
    }
}
