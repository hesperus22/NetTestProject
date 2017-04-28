using System;
using NUnit.Framework;
using Project;

namespace TestProject
{
    [TestFixture]
    public class Class3Test
    {
        [Test]
        public void TestUnsupported()
        {
            Assert.Throws<Exception>(() => new Class3().Unsupported());
        }
    }
}