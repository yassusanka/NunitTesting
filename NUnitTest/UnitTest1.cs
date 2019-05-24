using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void multiplicationtest()
        {
            
            Assert.AreEqual(6,Program.multiply(2,3));
        }

        [Test]
        public void divideTest()
        {
            Assert.AreEqual( 20,Program.divide(100,5));
            Assert.AreEqual(5,Program.divide( 100,20));
        }
    }
    
    public class Program
    {
        public  static int multiply(int x, int y) => x * y;
        public static int divide(int x, int y) => x / y;
    }
}