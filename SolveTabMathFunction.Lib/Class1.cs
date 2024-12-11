using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTabMathFunction.Lib
{
    public class TabMathFunction
    {
        public double[] CalculateFirstExpression(int start, int stop)
        {

            int len = stop - start + 1;

            double[] mas = new double[len + 1];

            for (int i = 0; i < len + 1; i++)
            {
                if (start == 0)
                { 
                mas[start] = 0;
                }
                else
                mas[i] = Math.Round((Math.Pow(start, 2) - Math.Pow(start, 3)) - ((Math.Pow(Math.Cos(start), 3) + 7 * Math.Pow(start, 2)) / ((Math.Pow(start, 3) - 15 * start))) / (Math.Pow(Math.Cos(start), 2)), 2);
                start++;
            }

            return mas;
        }
    }
}
