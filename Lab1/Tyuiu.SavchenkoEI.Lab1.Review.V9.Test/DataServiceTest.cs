using Tyuiu.SavchenkoEI.Lab1.Review.V9.Lib;

namespace Tyuiu.SavchenkoEI.Lab1.Review.V9.Test
{
    public class DataServiceTest
    {
        [Test]
        public void CheckCalc()
        {
            double x = 2.9;
            double y = 0.3;

            DataService ds = new DataService();

            double result = ds.Calc(x, y);

            double true_val = 21.881;

            Assert.AreEqual(true_val, result);
        }
    }
}