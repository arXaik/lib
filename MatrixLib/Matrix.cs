namespace MatrixLib
{
    public class Matrix
    {
        public static void FillMatrix(ref double[,] mas)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int cols = mas.Length / rows;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    mas[row, col] = Math.Pow(-2.3, row + col + 2) * Math.Pow(Math.Log(Math.Pow(3, (double)(row + 6) / (col + 1)), 2), 2)
                        + Math.Pow(-0.2, row + col + 3) * Math.Pow(Math.PI, 2 * (row + 1));
                }
            }
        }

        public static double[] GetVector(double[,] mas)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int cols = mas.Length / rows;

            int row_index = 0;
            double sum = 0;

            for (int row = 0; row < rows; row++)
            {
                double cur_sum = 0;
                for (int col = 0; col < cols; col++)
                {
                    cur_sum += mas[row, col];
                }

                if (row == 0)
                {
                    sum = cur_sum;
                }

                if (cur_sum < sum)
                {
                    sum = cur_sum;
                    row_index = row;
                }
            }

            double[] result = new double[cols];
            for (int col = 0; col < cols; col++)
            {
                result[col] = mas[row_index, col];
            }
            return result;
        }
    }
}