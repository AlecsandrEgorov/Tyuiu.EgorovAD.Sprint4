using Tyuiu.EgorovAD.Sprint4.Task2.V12.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 6, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
