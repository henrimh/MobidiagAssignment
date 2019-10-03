using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MobidiagUnitTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void SumEvenNumbersUpToTest()
        {
            //Arrange
            int param = 100;
            
            //In Fibonaccis' sequence the numbers under hundred are:
            // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            // The sum of even numbers from these is 44
            int expected = 44;
            int result;

            result = Fibonacci.Fibonacci.SumEvenNumbersUpTo(param);

            Assert.AreEqual(result, expected);
        }
    }
}
