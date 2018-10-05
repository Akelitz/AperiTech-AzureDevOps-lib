using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AperiTech.AzureDevOps.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanSumTwoNumbers()
        {
            var sut = new Calculator();

            var expectedResult = 3;
            var actualResult = sut.Sum(1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
