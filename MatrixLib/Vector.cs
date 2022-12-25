namespace MatrixLib
{
    public class Vector
    {
        public static double GetSumSquare(double[] vector)
        {
            double sum = 0;
            for (int number = 0; number < vector.Length; number++)
            {
                if (vector[number] < 0)
                {
                    sum += vector[number] * vector[number];
                }
            }
            return sum;
        }
    }
}