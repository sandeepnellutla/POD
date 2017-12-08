namespace POD.ServiceMonitor.Models.HomeViewModel
{
    public class HomeViewModel
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string IpAddress { get; set; }
        public string ServicePath { get; set; }
        public int ResponseTime { get; set; }
        public int Status { get; set; }
        public string IconCss { get; set; }
        public string StatusName { get; set; }

        public HomeViewModel(int id, string svcName, string svcPath, string ipAddress, int respTime = 0, int status=0)
        {
            Id = id;
            ServiceName = svcName;
            ServicePath = svcPath;
            IpAddress = ipAddress;
            ResponseTime = respTime;
            Status = status;
            switch (status) 
            {
                case 0: IconCss = "img-question-emo";
                        StatusName = "Unknown";
                        break;
                case 1: IconCss = "img-check";
                        StatusName = "Running";
                        break;
                case 2: IconCss = "img-delete";
                        StatusName = "Stopped";
                        break;
                default: IconCss = "img-question-emo";
                        StatusName = "Unknown";
                        break;
            }
        }
    }
}