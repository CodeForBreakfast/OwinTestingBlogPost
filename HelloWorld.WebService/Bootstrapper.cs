using System.Collections.Generic;

using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace HelloWorld.WebService
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override IEnumerable<ModuleRegistration> Modules
        {
            get { yield return new ModuleRegistration(typeof(FriendlyModule)); }
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
        }
    }
}