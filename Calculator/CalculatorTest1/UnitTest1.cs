using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            //Arrange
            //initializes objects and sets the value of the data that is passed to the method under test.
            Calculators bm = new Calculators();
            //Art
            //invokes the method under test with the arranged parameters.
            double resultat = bm.Add(10, 10);
            //Assert
            //verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(resultat, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.Substract(10, 10);
            //Assert
            Assert.AreEqual(resultat, 0);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.divide(10, 5);
            //Assert
            Assert.AreEqual(resultat, 2);
        }


        [TestMethod]
        public void Test_MultiplyMethod()
        {
            //Arrange
            BasicMaths bm = new BasicMaths();
            //Art
            double resultat = bm.Multiply(10, 5);
            //Assert
            Assert.AreEqual(resultat, 50);
        }
    }
}
