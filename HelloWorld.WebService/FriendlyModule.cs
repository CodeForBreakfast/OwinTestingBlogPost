using Nancy;

namespace HelloWorld.WebService
{
    public class FriendlyModule : NancyModule
    {
        public FriendlyModule()
        {
            Get["/hello"] = _ => "Howdy!";
        }
    }
}