using NUnit.Framework;

namespace Task3.UnitTests
{
    class IntegerHandlerTests
    {
        [TestCase(12, Result = 21)]
        [TestCase(513, Result = 531)]
        [TestCase(2017, Result = 2071)]
        [TestCase(414, Result = 441)]
        [TestCase(1234321, Result = 1241233)]
        [TestCase(1234126, Result = 1234162)]
        [TestCase(3456432, Result = 3462345)]
        [TestCase(10, Result = -1)]
        [TestCase(20, Result = -1)]

        public static int TestNextBiggerNumber(int number)
        {
            return IntegerHandler.NextBiggerNumber(number);
        }
    }
}
