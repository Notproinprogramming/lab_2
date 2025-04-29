using lab_2;
using NUnit.Framework.Legacy;
using NUnit.Framework;
namespace Lab_2_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BubbleSortTest()
        {
            int[] array =       { 4 , 2 , 9 , 6 , 5 , 1 };
            int[] expected =    { 1 , 2 , 4 , 5 , 6 , 9 };
            int[] sortedArray = Sorting.BubbleSort(array, array.Length);
            Assert.That(expected,Is.EquivalentTo(sortedArray));
        }

        [Test]
        public void BubbleSortTest2()
        {
            int[] array = { 1 , 2 , 3 , 4 , 5 , 6 };
            int[] expected = { 1 , 2 , 3 , 4 , 5 , 6 };
            int[] sortedArray = Sorting.BubbleSort(array, array.Length);
            Assert.That(expected, Is.EquivalentTo(sortedArray));
        }

        [Test]
        public void Main_ShouldReturnErrorCode_WhenInputIsNotNumber()
        {
            // Arrange
            var args = new[] { "123", "abc", "456" }; // "abc" не число
            var errorOutput = new StringWriter();
            Console.SetError(errorOutput);

            // Act
            int returnCode = lab_2.Program.Main(args);

            // Assert
            string errorText = errorOutput.ToString();
            Assert.That(1, Is.EqualTo(returnCode));
            StringAssert.Contains(errorText, "Input in a place 2 was not a number");
        }

        [Test]
        public void Main_ShouldReturnErrorCode_WhenAllInputsAreNotNumbers()
        {
            // Arrange
            var args = new[] { "fourteen", "two", "thirty six" }; // усі числа введені літерами
            var errorOutput = new StringWriter();
            Console.SetError(errorOutput);

            // Act
            int returnCode = lab_2.Program.Main(args);

            // Assert
            string errorText = errorOutput.ToString();
            Assert.That(1, Is.EqualTo(returnCode));
            StringAssert.Contains(errorText, "Input in a place 1 was not a number");

        }

        [Test]
        public void Main_ShouldReturnErrorCode_WhenInputIsEmpty()
        {
            // Arrange
            var args = new[] { "" }; 
            var errorOutput = new StringWriter();
            Console.SetError(errorOutput);

            // Act
            int returnCode = lab_2.Program.Main(args);

            // Assert
            string errorText = errorOutput.ToString();
            Assert.That(1, Is.EqualTo(returnCode));
            StringAssert.Contains(errorText, "Input in a place 1 was not a number");
        }
    }
}
