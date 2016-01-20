using HelloWorld.WebService;

using Nancy.Owin;

using Owin;

namespace HelloWorld.Owin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy(new NancyOptions
            {
                Bootstrapper = new Bootstrapper()
            });
        }
    }
}