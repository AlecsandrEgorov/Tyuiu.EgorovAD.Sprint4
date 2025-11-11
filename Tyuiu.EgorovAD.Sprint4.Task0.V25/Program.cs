using Tyuiu.EgorovAD.Sprint4.Task0.V25.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetSumEvenArrEl(array);



            Console.WriteLine(res);
            Console.ReadKey();  
        }
    }
}
