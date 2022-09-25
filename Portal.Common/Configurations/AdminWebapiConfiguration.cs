using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Common.Configurations
{
    public class AdminWebapiConfiguration
    {
        AdminWebapiConfiguration_ConnectionStrings ConnectionStrings { get; set; } = new AdminWebapiConfiguration_ConnectionStrings();
    }

    public class AdminWebapiConfiguration_ConnectionStrings
    {
        public string PortalDb { get; set; }
    }
    public class AdminWebapiConfiguration_AppSettings
    {
        public AzureAdConfiguration AzureAd { get; set; } = new AzureAdConfiguration();
    }
}
