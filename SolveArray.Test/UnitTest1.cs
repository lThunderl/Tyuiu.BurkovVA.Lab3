using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveArray.Lib;
using System.Collections.Generic;

namespace SolveArray.Test
{
    [TestClass]
    public class ValidArray
    {
        [TestMethod]
        public void TestCalculateMinimum()
        {
            int wait = 0;

            MyArray arr = new MyArray();
            int res = arr.CalculateMinimum(2, 0, 1);

            Assert.AreEqual(wait, res);
        }

        public void TestCalculateMaximum()
        {
            int wait = 1;

            MyArray arr = new MyArray();
            double res = arr.CalculateMaximum(2, 0, 1);

            Assert.AreEqual(wait, res);
        }
        public void TestCalculateAverage()
        {
            double wait = 0.5;

            MyArray arr = new MyArray();
            double res = Math.Round(arr.CalculateAverage(2, 0, 1), 1);

            Assert.AreEqual(wait, res);
        }

        public void TestCalculateMedian()
        {
            double wait = 0.5;

            MyArray arr = new MyArray();
            double res = Math.Round(arr.CalculateAverage(2, 0, 1), 1);

            Assert.AreEqual(wait, res);
        }

        public void TestCalculateNumberOfEven()
        {
            List<int> wait = new List<int>();

           
            MyArray arr = new MyArray();
            List<int> res = arr.CalculateNumberOfEven(2, 2, 4);
            
            foreach(int e in res)
            {
                if (e % 2 == 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }
        public void TestCalculateNumberOfOdd()
        {
            List<int> wait = new List<int>();


            MyArray arr = new MyArray();
            List<int> res = arr.CalculateNumberOfOdd(2, 2, 4);

            foreach (int e in res)
            {
                if (e % 2 != 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }

        public void TestSignsOfDivisibilityByTwo()
        {
            List<int> wait = new List<int>();


            MyArray arr = new MyArray();
            List<int> res = arr.SignsOfDivisibilityByTwo(2, 2, 4);

            foreach (int e in res)
            {
                if (e % 2 == 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }

        public void TestSignsOfDivisibilityByThree()
        {
            List<int> wait = new List<int>();


            MyArray arr = new MyArray();
            List<int> res = arr.SignsOfDivisibilityByThree(2, 2, 3);

            foreach (int e in res)
            {
                if (e % 3 == 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }
        public void TestSignsOfDivisibilityByFive()
        {
            List<int> wait = new List<int>();


            MyArray arr = new MyArray();
            List<int> res = arr.SignsOfDivisibilityByFive(2, 2, 3);

            foreach (int e in res)
            {
                if (e % 5 == 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }
        public void TestSignsOfDivisibilityByTen()
        {
            List<int> wait = new List<int>();


            MyArray arr = new MyArray();
            List<int> res = arr.SignsOfDivisibilityByTen(2, 2, 3);

            foreach (int e in res)
            {
                if (e % 10 == 0)
                {
                    wait.Add(e);
                }
            }
            Assert.AreEqual(wait, res);
        }
    }
}
