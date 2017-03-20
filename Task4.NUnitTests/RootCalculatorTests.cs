using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task4.NUnitTests
{
    class RootCalculatorTests
    {
        public IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new TestCaseData(-10d, -1d, 0.000001d).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(-10d, 2d, 0.000001d).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(10d, 2d, -0.000001d).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(10d, 2d, 0d).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(81d, 4d, 0.000000001d).Returns(3);
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public static double Root_Test_Yeild(double number, double power, double precision)
        {
            return RootCalculator.ComputeRoot(number, power, precision);
        }
    }
}
