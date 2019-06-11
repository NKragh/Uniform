using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniformUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var current = "";
            var expected = "hejsa";
            //act
            current.Method();
            //assert
            Assert.Equals(expected, current);
        }
    }
}
