namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void BasicAdditionTest()
        {
            // Given (Arrange)
            int a = 10, b = 20, answer;
            // When (Act)
            answer = a + b; // "System Under Test (SUT)"
            // Then (Assert)
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(10, 5, 15)]
        [InlineData(13, 3, 15)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}