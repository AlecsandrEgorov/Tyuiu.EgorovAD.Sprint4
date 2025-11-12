using Tyuiu.EgorovAD.Sprint4.Task3.V11.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[3, 3] {{ 1, 2, 3 },
                                         { 1, 2, 3 },
                                         { 1, 2, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 6;
            Assert.AreEqual(res, wait);
        }
    }
}
