using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MobidiagUnitTests
{
    [TestClass]
    public class CollatzSequenceTests
    {
        [TestMethod]
        public void SolveSequenceLengthTest()
        {
            //arrange
            int param = 13;
            int expected = 10;
            int result;

            //act
            result = Collatz.CollatzSequence.SolveSequenceLength(param);

            //assert
            Assert.AreEqual(result, expected);
        }
    }
}
