using System.Threading;

using HelloWorld.Owin;

using Microsoft.Owin.Hosting;

namespace HelloWorld.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://+:9999"))
                while (true)
                    Thread.Sleep(2000);
        }
    }
}