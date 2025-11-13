using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.EgorovAD.Sprint4.Task4.V15.Lib
{
    public class DataService : ISprint4Task4V15
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        sum+= matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
