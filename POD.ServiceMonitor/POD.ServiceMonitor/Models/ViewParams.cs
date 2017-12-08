using System.Collections.Generic;
using System.Linq.Expressions;

namespace POD.ServiceMonitor.Models
{
    public static class ViewParams
    {
        public static List<HomeViewModel.HomeViewModel> GetData()
        {
            var list = new List<HomeViewModel.HomeViewModel>()
            {
                new HomeViewModel.HomeViewModel(1, "Get Practice Data","Practice/GetPracticeInfoData", "http://localhost:9001",890,1),
                new HomeViewModel.HomeViewModel(2, "Get User Profile Data",  "User/GetUserProfileData", "http://localhost:9002", 230 ),
                new HomeViewModel.HomeViewModel(3,  "Get User Authentication Information",  "UserAuth/GetUserAuthData", "http://localhost:9003",700 ,2),
                new HomeViewModel.HomeViewModel(4,  "Get User Login Session Information",  "UserLogin/GetUserLoginSessionData",  "http://localhost:9004",180,1),
                new HomeViewModel.HomeViewModel(5,  "Get Procedures For A Clinic",  "Procedure/GetProcedureDataByClinic",  "http://localhost:9005",320,1),
                new HomeViewModel.HomeViewModel(6,  "Get Invoice Data By Patient Number",  "Billing/GetInvoiceDataByPatNum",  "http://localhost:9006",523,2)
            };

            return list;
        }
    }
}