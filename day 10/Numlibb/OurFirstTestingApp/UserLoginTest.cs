using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OurFirstTestingApp
{
    [TestFixture]   
    internal class UserLoginTest
    {
        [Test]
        public void SimpleEqualTest() 
        {
            int num1 = 52;
            int num2 = 52;
            Assert.AreEqual(num1, num2);
        }
        
    }
}
