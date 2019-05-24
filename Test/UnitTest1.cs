using System;

using NUnit.Framework;
using NUnit.Framework.Internal;


namespace SampleUnitTest.Test
{
    [TestFixture ]
    public class Tests
    {
        [Test] 
        public void additionTest()
        {
            Assert.AreEqual(5,Program.addition(4,1) );
                 }

        [Test]
        public void additionTest1()
        {
            Assert.AreEqual(15,Program.addition(10,5) );
        }

        [Test]

        public void subtractionTest()
        {
            Assert.AreEqual(5, Program.subtraction(10, 5));
            Assert.AreEqual(10,Program.subtraction(20,10));
        }
    }
    
    class Program
    {
        public  static int addition(int x, int y) => x + y;
        public static int subtraction(int x, int y) => x - y;
        
    }
}