using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using week02_01;

namespace UnitTestForWeek2Class1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addYtoXTestMethod()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addYtoX(ref x, ref y);


            //Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}
