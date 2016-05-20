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
            string[] returnedArray;

            //Act
            returnedArray = Program.readUntilEnd();


            //Assert
            Assert.IsTrue(returnedArray.Length == 0); //fail
        }

    }
}
