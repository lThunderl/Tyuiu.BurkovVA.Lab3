using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double a, double x, double y)
        {
            return 3 * x - (3 * x + a - 4 * a) / (3 * a + 2 * x + 6 * y) + ((a * x) / y + a / 2) / (3 * a / x) + 2 * x;
        }
    }
}
