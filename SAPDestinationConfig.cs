using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP
{
    public class SAPDestinationConfig : IDestinationConfiguration
    {

        public static RfcConfigParameters parms;
        public bool ChangeEventsSupported()
        {
            return false;
        }
        public static RfcDestination rfcDestination;

        public RfcConfigParameters GetParameters(String destinationName)
        {

            RfcConfigParameters parms = new RfcConfigParameters();

            switch (destinationName)
            {
                case "DDM": // SAP Dev
                    {
                        parms.Add(RfcConfigParameters.MessageServerHost, ""); // SAP IP
                        parms.Add(RfcConfigParameters.SystemID, "DDM");
                        parms.Add(RfcConfigParameters.GatewayHost, "");
                        parms.Add(RfcConfigParameters.SystemNumber, "");// SAP SystemNumber
                        parms.Add(RfcConfigParameters.User, ""); // RFC User
                        parms.Add(RfcConfigParameters.Password, ""); // RFC Password
                        parms.Add(RfcConfigParameters.Client, ""); // SAP Client
                        parms.Add(RfcConfigParameters.Language, "EN");
                        parms.Add(RfcConfigParameters.PoolSize, "5");
                        parms.Add(RfcConfigParameters.MaxPoolSize, "10");
                        parms.Add(RfcConfigParameters.IdleTimeout, "600");
                        break;
                    }
                case "QDM": // SAP Qlt
                    {
                        parms.Add(RfcConfigParameters.MessageServerHost, ""); // SAP IP
                        parms.Add(RfcConfigParameters.SystemID, "QDM");
                        parms.Add(RfcConfigParameters.GatewayHost, "");
                        parms.Add(RfcConfigParameters.SystemNumber, "");// SAP SystemNumber
                        parms.Add(RfcConfigParameters.User, ""); // RFC User
                        parms.Add(RfcConfigParameters.Password, ""); // RFC Password
                        parms.Add(RfcConfigParameters.Client, ""); // SAP Client
                        parms.Add(RfcConfigParameters.Language, "EN");
                        parms.Add(RfcConfigParameters.PoolSize, "5");
                        parms.Add(RfcConfigParameters.MaxPoolSize, "10");
                        parms.Add(RfcConfigParameters.IdleTimeout, "600");
                        break;
                    }
                case "PDM": // SAP Prod
                    {
                        parms.Add(RfcConfigParameters.MessageServerHost, ""); // SAP IP
                        parms.Add(RfcConfigParameters.SystemID, "PDM");
                        parms.Add(RfcConfigParameters.GatewayHost, "");
                        parms.Add(RfcConfigParameters.SystemNumber, "");// SAP SystemNumber
                        parms.Add(RfcConfigParameters.User, ""); // RFC User
                        parms.Add(RfcConfigParameters.Password, ""); // RFC Password
                        parms.Add(RfcConfigParameters.Client, ""); // SAP Client
                        parms.Add(RfcConfigParameters.Language, "EN");
                        parms.Add(RfcConfigParameters.PoolSize, "5");
                        parms.Add(RfcConfigParameters.MaxPoolSize, "10");
                        parms.Add(RfcConfigParameters.IdleTimeout, "600");
                        break;
                    }
            }
            return parms;
        }
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;
    }
}
