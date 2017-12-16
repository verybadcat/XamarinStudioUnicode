using System;
using NUnit.Framework;

namespace XamarinStudioUnicode
{
    [TestFixture]
    public class UnicodeTests
    {
        [Test]
        public void HelloWorld()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void TestUtf32()
        {
            var input = 0x0001D45A; // mathematical italic small m

            var stringified = Char.ConvertFromUtf32(input);
            var chars = stringified.ToCharArray();
            var char0 = chars[0];
            var char1 = chars[1];

            
        }
    }
}
