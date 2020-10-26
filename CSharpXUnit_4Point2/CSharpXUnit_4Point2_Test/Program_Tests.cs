using CSharpXUnit_4Point2;
using Xunit;

namespace CSharpXUnit_4Point2_Test
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2, 1)]
        
        public void DivideByTwo_Valid(int input, int expected)
        {
            //Arrange
            int output;




            //Act
            output = Program.DivideByTwo(input);

            //Assert
        }
    }
}
