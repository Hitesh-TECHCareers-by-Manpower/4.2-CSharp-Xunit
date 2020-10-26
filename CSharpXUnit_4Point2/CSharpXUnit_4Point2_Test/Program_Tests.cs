using CSharpXUnit_4Point2;
using Xunit;

namespace CSharpXUnit_4Point2_Test
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(3, 1)]
        [InlineData(0, 0)]
        [InlineData(-2, -1)]
        [InlineData(int.MaxValue, 1073741823)]
        [InlineData(int.MinValue, -1073741824)]


        public void DivideByTwo_Valid(int input, int expected)
        {
            //Arrange
            int output;


            //Act
            output = Program.DivideByTwo(input);

            //Assert
            Assert.Equal(expected, output);

        }
    }
}
