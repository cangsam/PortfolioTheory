using Nancy;
using Nancy.Bootstrapper;
using Nancy.Session;
using TinyIoC;

namespace portfolioServices
{
    public class NancyBootStrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            CookieBasedSessions.Enable(pipelines);
        }
    }
}