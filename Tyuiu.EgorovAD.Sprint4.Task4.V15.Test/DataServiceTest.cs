using Tyuiu.EgorovAD.Sprint4.Task4.V15.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[3, 3] {{ 2, 3, 6 },
                                         { 3, 3, 3 },
                                         { 4, 5, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 20;
            Assert.AreEqual(res, wait);
        }
    }
}
