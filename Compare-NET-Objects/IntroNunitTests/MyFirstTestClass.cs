using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntroNunitTests
{
    [TestFixture]
    public class MyFirstTestClass
    {
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x,y);
        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("This is a Failure,Crap");
        }

        [Test]
        public void ExpectedExceptionTest()
        {
            Assert.Throws(typeof(NotSupportedException), () =>
            {
                throw new NotSupportedException();
            });
        }
    }
}
