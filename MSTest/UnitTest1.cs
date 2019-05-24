using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//MS Test frame work.
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            bool expected = true;
            var actual = new Prime();
            bool flag = actual.primecheck(5);
            
            Assert.IsTrue( flag);
            Assert.AreEqual(expected,flag);

        }
    }

    public class Prime
    {
        public  bool primecheck(int n)
        {
            bool flag = true;
            int i = 2;
            
                if (n % i == 1)
                {

                    return flag;
                }
                else
                {
                    flag = false;
                }
            

            return flag;
        }
        
    }
}