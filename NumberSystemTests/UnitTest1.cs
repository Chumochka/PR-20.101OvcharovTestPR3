using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumberSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DecimaltoBinaryTest()
        {
            int num = 25;
            Int64 expected = 11001;

            NumberSystemFuntions.MainClass main = new NumberSystemFuntions.MainClass();
            Int64 actual = main.DecimaltoBinary(num);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimaltoOctalTest()
        {
            int num = 25;
            int expected = 31;

            NumberSystemFuntions.MainClass main = new NumberSystemFuntions.MainClass();
            int actual = main.DecimaltoOctal(num);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimaltoHexadecimalTest()
        {
            int num = 25;
            string expected = "19";

            NumberSystemFuntions.MainClass main = new NumberSystemFuntions.MainClass();
            string actual = main.DecimalToHexadecimal(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
