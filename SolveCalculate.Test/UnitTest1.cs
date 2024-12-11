using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    [TestClass]
    public class ValidCalculate
    {
        Calculate res = new Calculate();
        [TestMethod]
        public void TestCalculateSumma()
        {
        double a = 5;
        double b = 3;
        double wait = 8;

        double result = res.CalculateSumma(a, b);
            Assert.AreEqual(wait, result);

        }

        public void TestCalculateDifference()
        {

            double a = 5;
            double b = 3;
            double wait = 2;

            double result = res.CalculateDifference(a, b);
            Assert.AreEqual(wait, result);
        }
        public void TestCalculateMultiplication()
        {

            double a = 5;
            double b = 3;
            double wait = 15;

            double result = res.CalculateDifference(a, b);
            Assert.AreEqual(wait, result);
        }
        public void TestCalculateQuotient()
        {

            double a = 5;
            double b = 3;
            double wait = 1.67;

            double result = res.CalculateDifference(a, b);
            Assert.AreEqual(wait, Math.Round(result, 2));
        }
    }
}
