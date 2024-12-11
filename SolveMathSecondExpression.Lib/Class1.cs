using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateMathSecondExpression(double a, double x, double y)
        {
            return 4 * x + ((2 + y + x - 3 * a) / (x - 7 * y)) - (a / y / 3 * a / x);
        }
    }
}