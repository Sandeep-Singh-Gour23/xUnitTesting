using System;
using UnitTestingForString;
using Xunit;

namespace xUnitTestString
{
    public class LengthHelperTest
    {
        LengthHelper helper = new LengthHelper();

        [Fact]
        public void Test1()
        {
            // Arrange  
            string str = "Sandeep";
            int expectedValue = 7;

            // Act  
            int returned_value  = helper.findLength(str);

            //Assert  
            Assert.Equal(expectedValue, returned_value);

        }
        [Fact]
        public void Test2()
        {
            // Arrange  
            string str = "";
            int expectedValue = 0;

            // Act  
            int returned_value = helper.findLength(str);

            //Assert  
            Assert.Equal(expectedValue, returned_value);

        }
        [Fact]
        public void Test3()
        {
            // Arrange  
            string str = "123";
            int expectedValue = 3;

            // Act  
            int returned_value = helper.findLength(str);

            //Assert  
            Assert.Equal(expectedValue, returned_value);

        }
        [Fact]
        public void Test4()
        {
            // Arrange  
            string str = "123456789010";
            int expectedValue = 12;

            // Act  
            int returned_value = helper.findLength(str);

            //Assert  
            Assert.Equal(expectedValue, returned_value);

        }
        [Fact]
        public void Test5()
        {
            // Arrange  
            string str = "NULL";
            int expectedValue = 4;

            // Act  
            int returned_value = helper.findLength(str);

            //Assert  
            Assert.Equal(expectedValue, returned_value);

        }
    }
}
