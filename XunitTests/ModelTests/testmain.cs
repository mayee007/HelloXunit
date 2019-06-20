using Xunit; 
namespace XUnitTests.ModelTests 
{
    [Trait("Category","model")]
    public class testmain 
    {
        [Fact]
        public void TestingMainFunction()
        {
            Assert.Equal(12 , HelloXunit.Program.Add(10,2)); 
        }

        [Theory]
        [InlineData(12, 10, 2)]
        [InlineData(200, 100, 100)]
        [InlineData(0, 1, -1)]
        public void TestingAddFunctionSecondWay(int expected, int firstVal, int secondVal)
        {
            Assert.Equal(expected , HelloXunit.Program.Add(firstVal, secondVal));
        }
    }
}