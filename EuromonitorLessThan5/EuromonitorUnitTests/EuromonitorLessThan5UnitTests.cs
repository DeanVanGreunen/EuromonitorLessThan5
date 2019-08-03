using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuromonitorLessThan5;

namespace EuromonitorUnitTests
{
    [TestClass]
    public class EuromonitorLessThan5Tests
    {
        #region Valid Input Tests (Values Less Than 5)
        [TestMethod]
        public void TestValidInput1()
        {
            int inputValue = 3;
            int expected = 2;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        [TestMethod]
        public void TestValidInput2()
        {
            int inputValue = 2;
            int expected = 3;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        [TestMethod]
        public void TestValidInput3()
        {
            int inputValue = 4;
            int expected = 1;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        #endregion 

        #region Invalid Input Tests (values more than or equal to 5
        [TestMethod]
        public void TestInvalidInput1()
        {
            int inputValue = 5;
            int expected = 0;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        [TestMethod]
        public void TestInvalidInput2()
        {
            int inputValue = 6;
            int expected = -1;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        [TestMethod]
        public void TestInvalidInput3()
        {
            int inputValue = 7;
            int expected = -2;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        [TestMethod]
        public void TestInvalidInput4()
        {
            int inputValue = 9;
            int expected = -4;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        #endregion

        #region Valid Input Tests (Values Less than or equal to 0)

        [TestMethod]
        public void TestValidInputNeg1()
        {
            int inputValue = -1;
            int expected = 6;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }

        [TestMethod]
        public void TestValidInputNeg2()
        {
            int inputValue = -4;
            int expected = 9;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }

        [TestMethod]
        public void TestValidInputNeg3()
        {
            int inputValue = 0;
            int expected = 5;
            int actual = EuromonitorMath.GetDifferenceToMake5(inputValue);
            Assert.AreEqual(expected, actual, string.Format("The number required to get to 5 is {0} which is correct with input of {1}.", actual, inputValue));
        }
        #endregion
    }
}
