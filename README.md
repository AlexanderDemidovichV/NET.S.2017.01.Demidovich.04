# NET.S.2017.01.Demidovich.04

Task1:

>*Разработать unit-тесты с использованием как NUnit Framework, так и MS Unit Test Framework (здесь использовать подход  Data Driven Testing, пример в архиве UnitTesting.zip, проекты DDT.Demo и DDT.Demo.Tests) для тестирования метода из задачи 3 дня 3 (ниже пример заготовки для тестового класса с использованием NUnit Famework-a). 

Task2:

public class *********Tests
   {
       [TestCase(8,15,0,0, ExpectedResult = 9)]
       [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
       [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
       [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
       [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
       [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
       [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
       [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
       [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
       [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
       public int ******_PositiveTest(int first, int second, int startPosition, int finishPosition)
       {
           return *****(first, second, startPosition, finishPosition);
       }
       
       [TestCase(8, 15, -1, 5)]
       [TestCase(8, 15, 5, -1)]
       [TestCase(8, 15, 31, 5)]
       [TestCase(8, 15, 5, 31)]
       public void ******_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
       {
           Assert.Throws<ArgumentOutOfRangeException>(() => ******(first, second, startPosition, finishPosition));
       }

       [TestCase(8, 15, 7, 5)]
       [TestCase(8, 15, 1, 0)]
       public void *******_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
       {
           Assert.Throws<ArgumentException>(() => *******(first, second, startPosition, finishPosition));
       }
   }
   
Task2:

>*Разработать unit-тесты для тестирования методов задач (дни 2-3). (здесь и далее желательно использовать для тестирования NUnit Framework).

Task3:

Реализовать метод NextBiggerNumber, который принимает положительное целое число и возвращает ближайше наибольшее  целое, состоящее из цифр исходного числа, и - 1 (null), если такого числа не существует. Примерные тест-кейсы

[TestCase(12, ExpectedResult = 21)]
[TestCase(513, ExpectedResult = 531)]
[TestCase(2017, ExpectedResult = 2071)]
[TestCase(414, ExpectedResult = 441)]
[TestCase(144, ExpectedResult = 414)]
[TestCase(1234321, ExpectedResult = 1241233)]
[TestCase(1234126, ExpectedResult = 1234162)]
[TestCase(3456432, ExpectedResult = 3462345)]
[TestCase(10, ExpectedResult = -1)]
[TestCase(20, ExpectedResult = -1)]

Task3:

>*Разработать метод, позволяющий вычислять корень n-ой степени (n - целое, положительное) из вещественного числа методом Ньютона с заданной точностью. Придерживаться следующей сингатуры метода
public static double *****(double *****, int *****, double *****)
При  некорректных входных данных выбрасывать соответствующие исключения. Разработать unit-тесты для тестирования полученного метода.
