using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            double a = 1;
            double x = 1;
            double y = 1;
            MathSecondExpression expr = new MathSecondExpression();

            double res = expr.CalculateMathSecondExpression(a, x, y);

            double wait = 3.5;

            Assert.AreEqual(Math.Round(wait, 1), Math.Round(res, 1));
        }
    }
}
