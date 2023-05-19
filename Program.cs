using System;
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool allCTRL = true;

            while (allCTRL)
            {
                Console.Write("Enter operation (+/-): ");
                string operation = Console.ReadLine();

                if (operation == "+" || operation == "-")
                {
                    Console.Write("Enter size of matrix (row and col): ");
                    int matrixSize1 = int.Parse(Console.ReadLine());
                    int matrixSize2 = int.Parse(Console.ReadLine());

                    float[,] matrixA = CreateMatrix(matrixSize1, matrixSize2);
                    float[,] matrixB = CreateMatrix(matrixSize1, matrixSize2);

                    switch (operation)
                    {
                        case "+":
                            float[,] matrixsum = MatrixPlus(matrixA, matrixB);

                            for (int i = 0; i < matrixSize1; i++)
                            {
                                for (int j = 0; j < matrixSize2; j++)
                                {
                                    Console.Write(matrixsum[i, j] + " ");
                                }
                            }

                            Console.WriteLine(" ");
                            break;

                        case "-":
                            float[,] matrixdiv = MatrixMinus(matrixA, matrixB);

                            for (int i = 0; i < matrixSize1; i++)
                            {
                                for (int j = 0; j < matrixSize2; j++)
                                {
                                    Console.Write(matrixdiv[i, j] + " ");
                                }
                            }

                            Console.WriteLine(" ");
                            break;

                        default:
                            allCTRL = false;
                            break;
                    }
                }
                else
                {
                    allCTRL = false;
                }
            }
        }
        static float[,] CreateMatrix(int matrixSize1, int matrixSize2)
        {
            float[,] matrixA = new float[matrixSize1, matrixSize2];

            Console.Write("Enter members of matrix: ");
            for (int i = 0; i < matrixSize1; i++)
            {
                for (int j = 0; j < matrixSize2; j++)
                {
                    matrixA[i, j] = float.Parse(Console.ReadLine());
                }
            }

            return matrixA;
        }
        static float[,] MatrixPlus(float[,] matrix1, float[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            float[,] result = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        static float[,] MatrixMinus(float[,] matrix1, float[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            float[,] result = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }
    }
}