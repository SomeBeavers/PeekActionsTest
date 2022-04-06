using NUnit.Framework;

namespace UT
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
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            // TODO: test
            ClassInTest classInTest_renamed = new ClassInTest();
            Assert.IsTrue(classInTest_renamed.BooleanProperty);
        }

        [Test]
        public void Test3()
        {
            ClassInTest classInTest = new ClassInTest();
            Assert.IsTrue(classInTest.BooleanProperty);
        }


        [Test]
        public void Test4()
        {
            ClassInTest classInTest = new ClassInTest();
            Assert.IsTrue(classInTest.BooleanProperty);
        }

        [Test]
        public void Test5()
        {
            ClassInTest classInTest = new ClassInTest();
            UsedMethod(classInTest);
            Assert.IsTrue(classInTest.BooleanProperty);
        }

        private void UsedMethod(ClassInTest someCoolName)
        {
            throw new System.NotImplementedException();
        }
    }

    internal interface ITestsImpl
    {
    }
}