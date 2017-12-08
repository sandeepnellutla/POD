using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;

[assembly: OwinStartup(typeof(POD.ServiceMonitor.Startup))]

namespace POD.ServiceMonitor
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
            //app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}
