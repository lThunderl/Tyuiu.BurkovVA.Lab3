using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveTabMathFunction.Lib;

namespace SolveTabMathFunction.Test
{
    [TestClass]
    public class ValidTabMathFunction
    {
        [TestMethod]
        public void TestCalculateTabMathFunction()
        {
            int start = 1;
            int stop = 11;

            int len = stop - start + 1;
            double[] massWait = new double[len];

            massWait[0] = 0;
            massWait[1] = 1.75;
            massWait[2] = 3.33;
            massWait[3] = -14.48;
            massWait[4] = -113.37;
            massWait[5] = -143.5;
            massWait[6] = -182.18;
            massWait[7] = -296.54;
            massWait[8] = -501.98;
            massWait[9] = -649.15;
            massWait[10] = -901.17;

            TabMathFunction res = new TabMathFunction();
            double[] mas = res.CalculateFirstExpression(start, stop);

            CollectionAssert.AreEqual(mas, massWait);
        }
    }
}
