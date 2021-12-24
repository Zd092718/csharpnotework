using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(Hello.HelloWorld, Is.EqualTo("Hello Worlds"));
        }

        public class Hello
        {
            public static string HelloWorld()
            {
                return "Hello World";
            }
        }
    }
}