using NUnit.Framework;
using Project.Ns1;

namespace TestProject.Ns1
{
    [TestFixture]
    public class Class1Test
    {
        [TestCase(5, 1, 4)]
        [TestCase(10, 5, 5)]
        [TestCase(10, 6, 4)]
        [TestCase(10, 10, 0)]
        public void TestAdd(int result, int a, int b)
        {
            Assert.AreEqual(result, new Class1().Add(a, b));
        }

        [TestCase(5, 1, 4)]
        [TestCase(10, 5, 5)]
        [TestCase(10, 6, 4)]
        [TestCase(10, 10, 0)]
        public void TestSub(int a, int b, int result)
        {
            Assert.AreEqual(result, new Class1().Sub(a, b));
        }

        [TestCase(5, 1, 5)]
        [TestCase(10, 5, 50)]
        [TestCase(10, 6, 60)]
        [TestCase(10, 10, 100)]
        public void TestMul(int a, int b, int result)
        {
            Assert.AreEqual(result, new Class1().Mul(a, b));
        }
    }
}