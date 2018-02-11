using System;
using Xunit;
using MQTTserver; 

namespace Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(7, 1, 8)]
        [InlineData(7, 11, 18)]
        public void Test1(int A, int B, int result)
        {
            int returned = Util.TestMeIAddNumbers(A, B);
            Assert.True(returned == result); 
        }
    }
}
