using Tyuiu.EgorovAD.Sprint4.Task5.V10.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите колво строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колво столбов в массиве:");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, colums];

            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 7);
                }
            }
            Console.WriteLine("\n Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matrix);
            Console.WriteLine();
            Console.WriteLine("Результат: " + res);
        }
    }
}
