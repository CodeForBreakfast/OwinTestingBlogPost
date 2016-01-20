using HelloWorld.Owin;

using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.AcceptanceTests
{
    [TestClass]
    public class FriendlyTests
    {
        private readonly TestServer server = TestServer.Create(app => new Startup().Configuration(app));

        [TestMethod]
        public void HelloSaysHowdy()
        {
            Assert.AreEqual("Howdy!", GetBody("/hello"));
        }

        private string GetBody(string path)
        {
            return server.CreateRequest(path)
                         .GetAsync().Result
                         .Content
                         .ReadAsStringAsync().Result;
        }
    }
}