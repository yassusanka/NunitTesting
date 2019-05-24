using System;
using Xunit;
//xUnit Framework
namespace xUnit1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            
                Assert.Equal(6,Program.multiply(2,3));
            }

            [Fact]
            public void divideTest()
            {
                Assert.Equal( 20,Program.divide(100,5));
                Assert.Equal(5,Program.divide( 100,20));
            }
        }

   
    

        public class Program
        {
            public  static int multiply(int x, int y) => x * y;
            public static int divide(int x, int y) => x / y;
        }
    }
        
    
