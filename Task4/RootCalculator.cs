using System;

namespace Task4
{
    /// <summary>
    /// Provides static methods for root calculating
    /// </summary>
    public static class RootCalculator
    {

        #region Public Methods

        /// <summary>
        /// Returns nth root of a specified number with specified precision
        /// </summary>
        /// <param name="number">A double-percision number whose root is to be found.</param>
        /// <param name="power">A number that specifies a power.</param>
        /// <param name="precision">A number that specifies a precision.</param>
        /// <returns>nth root of a specified number with specified precision.</returns>
        public static double ComputeRoot(double number, double power, double precision)
        {
            return Root(number, power, precision);
        }

        /// <summary>
        /// Returns nth root of a specified number
        /// </summary>
        /// <param name="number">A number whose root is to be found.</param>
        /// <param name="power">A number that specifies a power.</param>
        /// <returns>nth root of a specified number.</returns>
        public static double ComputeRoot(double number, double power)
        {
            return Root(number, power);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Returns nth root of a specified number with specified precision using Newton's method
        /// </summary>
        /// <param name="number">A double-percision number whose root is to be found.</param>
        /// <param name="power">A number that specifies a power.</param>
        /// <param name="precision">A number that specifies a precision.</param>
        /// <returns>nth root of a specified number with specified precision.</returns>
        private static double Root(double number, double power, double precision = 0.000001d)
        {
            if (precision <= 0d)
                throw new ArgumentOutOfRangeException(nameof(precision));

            if (number < 0d)
                throw new ArgumentOutOfRangeException(nameof(number));

            if (number == 0d)
                return 0d;

            if (number == 1d)
                return 1d;

            if (power == 0d)
                return 1d;

            if (power == 1d)
                return number;

            double x = number / power, _x = number;

            while(Math.Abs(x - _x) > precision)
            {
                _x = x;
                x = ((power - 1d) * x + number / Math.Pow(x, power - 1d)) / power;
            }

            return x;
        }

        #endregion

    }
}
