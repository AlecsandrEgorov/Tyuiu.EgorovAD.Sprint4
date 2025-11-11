using Tyuiu.EgorovAD.Sprint4.Task0.V25.Lib;
namespace Tyuiu.EgorovAD.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
