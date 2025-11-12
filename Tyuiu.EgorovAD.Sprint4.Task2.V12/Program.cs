using Tyuiu.EgorovAD.Sprint4.Task2.V12.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] aray = new int[len];

            for (int i = 0; i < aray.Length; i++)
            {
         
                aray[i] = rnd.Next(4,9);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(aray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            int res = ds.Calculate(aray);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
