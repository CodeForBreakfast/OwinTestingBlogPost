using System.Net.Http;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.AcceptanceTests
{
    [TestClass]
    public class FriendlyTests
    {
        private readonly HttpClient client = ApiHelper.CreateTestClient();

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