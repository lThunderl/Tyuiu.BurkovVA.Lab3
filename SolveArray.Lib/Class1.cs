using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveArray.Lib
{
    public class MyArray
    {
        public int CalculateMinimum(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            int min = 999;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] < min) min = array[i];
            }

                return min;
        }
        public double CalculateMaximum(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }
        public double CalculateAverage(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                sum += array[i];
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            return sum/a;
        }
        public double CalculateMedian(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Array.Sort(array);

            int middleIndex = array.Length / 2;
            double median;
            if (array.Length % 2 == 0)
            {
                median = (array[middleIndex - 1] + array[middleIndex]) / 2.0;
            }
            else
            {
                median = array[middleIndex];
            }

            return median;
        }
        public List<int> CalculateNumberOfEven(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> even = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 2 == 0)
                {
                    even.Add(array[i]);
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));


            return even;
        }

        public List<int> CalculateNumberOfOdd(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> odd = new List<int>();
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 2 != 0)
                {
                    odd.Add(array[i]);
                    count++;
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Console.WriteLine(count);
            return odd;
        }
        public List<int> SignsOfDivisibilityByTwo(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> divByTwo = new List<int>();
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 2 == 0)
                {
                    divByTwo.Add(array[i]);
                    count++;
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Console.WriteLine(count);
            return divByTwo;
        }
        public List<int> SignsOfDivisibilityByThree(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> divByThree = new List<int>();
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 3 == 0)
                {
                    divByThree.Add(array[i]);
                    count++;
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Console.WriteLine(count);
            return divByThree;
        }
        public List<int> SignsOfDivisibilityByFive(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> divByFive = new List<int>();
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 5 == 0)
                {
                    divByFive.Add(array[i]);
                    count++;
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Console.WriteLine(count);
            return divByFive;
        }

        public List<int> SignsOfDivisibilityByTen(int a, int X1, int X2)
        {
            int[] array = new int[a];
            int[] num = new int[a];
            List<int> divByTen = new List<int>();
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(X1, X2);
                num[i] = i + 1;
                if (array[i] % 10 == 0)
                {
                    divByTen.Add(array[i]);
                    count++;
                }
            }

            Console.WriteLine(String.Join(" | ", num));
            Console.WriteLine(String.Join(" | ", array));

            Console.WriteLine(count);

            return divByTen;
        }
    }
}
