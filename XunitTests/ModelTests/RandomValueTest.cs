using src.model;
using Xunit; 
//using Xunit.Repeat;
namespace XUnitTests.ModelTests
{
    [Trait("Category", "model")]
    [Trait("Category", "rand")]
    public class RandomValueTest 
    {
        RandonValueGenerator rand;

        public RandomValueTest()
        {
            rand = new RandonValueGenerator(1,10); 
        }
        //[Theory, Repeat(10)]
        // ***** getting this error for "Repeat" package
        // Package Xunit.Repeat 1.0.0 is not compatible with netcoreapp2.1 (.NETCoreApp,Version=v2.1)
        [Fact]        
        public void testRandom()
        {
            Assert.InRange(rand.getRandonValue(),1,10); 
            Assert.InRange(rand.getRandonValue(),1,10);
            Assert.InRange(rand.getRandonValue(),1,10);
            Assert.InRange(rand.getRandonValue(),1,10);
            Assert.InRange(rand.getRandonValue(),1,10);
        }

        [Theory]
        [InlineData(1,50)]
        [InlineData(100,500)]
        [InlineData(1,5)]
        [InlineData(-10,1)]
        [InlineData(1,2)]
        public void testRandomMultiple(int min, int max)
        {
            RandonValueGenerator rand2 = new RandonValueGenerator(min,max); 
            Assert.InRange(rand2.getRandonValue(),min,max); 
        }
    }
}