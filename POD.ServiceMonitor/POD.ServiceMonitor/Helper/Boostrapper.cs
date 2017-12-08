using System;
using System.IO;
using Nancy;
using Nancy.Hosting.Self;

namespace POD.ServiceMonitor.Helper
{
    public class Boostrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return new ServiceRootPathProvider(); }
        }
    }

    public class ServiceRootPathProvider : IRootPathProvider
    {
        private IRootPathProvider provider = new FileSystemRootPathProvider();

        public string GetRootPath()
        {
            var returnpath = AppDomain.CurrentDomain.BaseDirectory;// Path.GetFullPath(Path.Combine(provider.GetRootPath(), "..", ".."));
            return returnpath;
        }
    }
}