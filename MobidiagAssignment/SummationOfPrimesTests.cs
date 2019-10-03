using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MobidiagUnitTests
{
    [TestClass]
    public class SummationOfPrimesTests
    {
        [TestMethod]
        public void SumAllPrimesBelowTest()
        {
            // arrange
            int param = 10;
            long expected = 17; // 2+3+5+7 = 17
            long result;

            // act
            result = PrimeSummation.PrimeSummation.SumAllPrimesBelow(param);

            // assert
            Assert.AreEqual(expected, result);           
        }
    }
}
