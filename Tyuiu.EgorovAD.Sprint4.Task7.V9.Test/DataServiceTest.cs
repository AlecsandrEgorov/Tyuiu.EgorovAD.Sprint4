using Tyuiu.EgorovAD.Sprint4.Task7.V9.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 3;
            string str = "864278753";

            int res = ds.Calculate(rows, colums, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
