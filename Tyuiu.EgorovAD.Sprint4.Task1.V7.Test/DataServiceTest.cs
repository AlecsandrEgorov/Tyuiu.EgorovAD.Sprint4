using Tyuiu.EgorovAD.Sprint4.Task1.V7.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}
