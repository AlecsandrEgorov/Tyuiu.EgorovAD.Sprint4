using Tyuiu.EgorovAD.Sprint4.Task4.V15.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

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
                    Console.WriteLine($"Введите {i}, {j} элемент массива");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());                
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
            Console.WriteLine(res);
        }
    }
}
