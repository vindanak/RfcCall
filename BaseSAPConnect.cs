using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SAP
{
   public class BaseSAPConnect : IDisposable
    {
        protected static IDestinationConfiguration destinationConfig = null;
        protected static bool destinationIsInitilised = false;
        protected static RfcDestination rfcDestination;
        public static string destinationConfigName = ConfigurationManager.AppSettings["SAPDestination"].ToString();
        protected static RfcDestination currentRfcDestination;
        protected static RfcRepository rfcRepo = null;

        public BaseSAPConnect()
        {
            if (currentRfcDestination == null)
            {
                destinationConfig = new SAPDestinationConfig();
                destinationConfig.GetParameters(destinationConfigName);

                try
                {
                    currentRfcDestination = RfcDestinationManager.GetDestination(destinationConfigName);
                }
                catch (Exception)
                {
                    RfcDestinationManager.RegisterDestinationConfiguration(destinationConfig);
                    destinationIsInitilised = true;
                }

                rfcRepo = RfcDestinationManager.GetDestination(destinationConfigName).Repository;
            }
        }

        public void Dispose()
        {
            // destinationConfig = null;
        }
    }
}
