using System;
using System.Net.Http;

using HelloWorld.Owin;

using Microsoft.Owin.Builder;

namespace HelloWorld.AcceptanceTests
{
    internal static class ApiHelper
    {
        public static HttpClient CreateTestClient()
        {
            return new HttpClient(CreateOwinHttpMessageHandler())
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
    }
}