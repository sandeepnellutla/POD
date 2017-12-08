using Nancy;
using POD.ServiceMonitor.Models;

namespace POD.ServiceMonitor.Modules
{
    public class Home:NancyModule
    {
        public Home()
        {
            Get["/"] = _ => "Hello"; 
            Get["/start"] = _ => View["home/index"];
            Get["/home"] = _ => View["home/home", ViewParams.GetData()];
        }
    }
}