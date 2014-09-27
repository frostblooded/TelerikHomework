using System;

class Matrix
{
    int[,] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new int[rows, columns];
    }

    public int Rows
    {
        get
        {
            return matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return matrix.GetLength(1);
        }
    }

    public int this [int rows, int columns]
    {
        get
        {
            return matrix[rows, columns];
        }
        set
        {
            matrix[rows, columns] = value;
        }
    }

    public override string ToString()
    {
        string result = null;
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                result += matrix[i, j] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }

    //Overloaded Operators
    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Columns);
        for (int i = 0; i < firstMatrix.Rows; i++)
        {
            for (int j = 0; j < firstMatrix.Columns; j++)
            {
                resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Columns);
        for (int i = 0; i < firstMatrix.Rows; i++)
        {
            for (int j = 0; j < firstMatrix.Columns; j++)
            {
                resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator *(Matrix firstMatrix, int multiplier)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Columns);
        for (int i = 0; i < firstMatrix.Rows; i++)
        {
            for (int j = 0; j < firstMatrix.Columns; j++)
            {
                resultMatrix[i, j] = firstMatrix[i, j] * multiplier;
            }
        }
        return resultMatrix;
    }
}
