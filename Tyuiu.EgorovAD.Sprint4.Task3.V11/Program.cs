using Tyuiu.EgorovAD.Sprint4.Task3.V11.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] {{ 8, 6, 9, 4, 5 },
                                         { 9, 4, 8, 5, 6 },
                                         { 9, 7, 9, 8, 4 },
                                         { 4, 6, 5, 7, 8 },
                                         { 6, 6, 7, 6, 4 }};

            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;


            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mas2[i, j]} \t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas2);
            Console.WriteLine();
            Console.WriteLine(res);
        }
    }
}
