using TwoSum;
using Xunit;

namespace TestsTwoSum
{
    public class UnitTest1
    {
        Method _method = new Method();

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TestExample2(int[] nums, int target, int[] expected)
        {

            //Arrage


            //Act
            var actual = _method.TwoSum(nums, target);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}