using Tyuiu.EgorovAD.Sprint4.Task6.V4.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = new string[] {"Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара"};

            string[] res = ds.Calculate(array);

            string[] wait = ["Москва", "Самара" ];

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
