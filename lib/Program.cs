using MatrixLib;

namespace lib
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[,] matrix = new double[4, 8];

            Matrix.FillMatrix(ref matrix);

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;


            Console.WriteLine("Матрица: ");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{matrix[row, col]:F2} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($" {matrix[row, col]:F2} ");
                    }

                    switch (Math.Abs(matrix[row,col]))
                    {
                        case < 10: Console.Write("    "); break;
                        case < 100: Console.Write("   "); break;
                        case < 1000: Console.Write("  "); break;
                        case < 10000: Console.Write(" "); break;
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("Вектор: ");

            double[] vector = Matrix.GetVector(matrix);
            for (int index = 0; index < vector.Length; index++)
            {
                Console.ForegroundColor = vector[index] < 0 ? ConsoleColor.Red : ConsoleColor.White; 
                Console.Write($"{vector[index]:F2} ");
            }
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Функция: ");
            Console.WriteLine($"{Vector.GetSumSquare(vector):F2}");
        }
    }
}