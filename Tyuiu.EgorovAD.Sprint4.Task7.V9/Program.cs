using Tyuiu.EgorovAD.Sprint4.Task7.V9.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 3;
            string str = "864299753";
            int[,] mtrx = new int[rows, colums];

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив \n");

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, colums, str);

            Console.WriteLine("Количество четных элементов: " + res);
            Console.ReadKey();

        }
    }
}
