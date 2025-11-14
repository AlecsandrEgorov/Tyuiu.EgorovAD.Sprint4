using System.Diagnostics.Tracing;
using Tyuiu.EgorovAD.Sprint4.Task6.V4.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] cities = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] nums = ds.Calculate(cities);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadKey();

        }
    }
}
