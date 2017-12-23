using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebApplication.WebService1 myService = new WebApplication.WebService1();
            var result = myService.GetOutputText();
            Assert.AreEqual("Hello World", result);
        }
    }
}
