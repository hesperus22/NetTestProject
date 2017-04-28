using System;
using NUnit.Framework;
using Project.Ns1;

namespace TestProject.Ns1
{
    [TestFixture]
    public class Class2Test
    {
        [Test]
        public void TestHello()
        {
            new Class2().Hello();
        }
    }
}