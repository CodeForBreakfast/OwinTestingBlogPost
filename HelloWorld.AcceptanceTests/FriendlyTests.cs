using System;
using System.Net.Http;

using HelloWorld.Owin;

using Microsoft.Owin.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.AcceptanceTests
{
    [TestClass]
    public class FriendlyTests
    {
        private readonly HttpClient client;

        public FriendlyTests()
        {
            client = new HttpClient(CreateOwinHttpMessageHandler())
            {
                BaseAddress = new Uri("http://test")
            };
        }

        private static OwinHttpMessageHandler CreateOwinHttpMessageHandler()
        {
            var app = new AppBuilder();
            new Startup().Configuration(app);
            return new OwinHttpMessageHandler(app.Build());
        }

        [TestMethod]
        public void HelloSaysHowdy()
        {
            Assert.AreEqual("Howdy!", GetBody("/hello"));
        }

        private string GetBody(string path)
        {
            return client.GetAsync(path).Result
                         .Content
                         .ReadAsStringAsync().Result;
        }
    }
}