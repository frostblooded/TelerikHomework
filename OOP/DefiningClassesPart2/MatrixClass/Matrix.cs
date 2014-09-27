using System;
using System.Text;

namespace MatrixClass
{
    public class Matrix<T> where T : IComparable<T>
    {
        private T[,] matrix;

        public Matrix()
        {
            matrix = new T[3, 3];
        }

        public Matrix(int startingHeight, int startingWidth)
            : this()
        {
            matrix = new T[startingHeight, startingWidth];
        }

        public int GetLength(int dimensionIndex)
        {
            return matrix.GetLength(dimensionIndex);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result.Append(matrix[i, j] + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        public T this[int height, int width]
        {
            get
            {
                return matrix[height, width];
            }
            set
            {
                matrix[height, width] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));

                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < firstMatrix.GetLength(1); j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrices aren't addable.");
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));

                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < firstMatrix.GetLength(1); j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrices aren't subtractable.");
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetLength(0), secondMatrix.GetLength(1));

                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < secondMatrix.GetLength(1); j++)
                    {
                        int cellResult = 0;

                        for (int z = 0; z < firstMatrix.GetLength(1); z++)
                        {
                            cellResult += (dynamic)firstMatrix[i, z] * (dynamic)secondMatrix[z, j];
                        }

                        resultMatrix[i, j] = (dynamic)cellResult;
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrices aren't mulitpliable.");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!matrix[i, j].Equals((dynamic)0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!matrix[i, j].Equals((dynamic)0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
