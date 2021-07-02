using SAP.DTO;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP
{
  public  class RfcCallManager : BaseSAPConnect
    {
        public RfcCallManager()
        {
            if (rfcDestination == null)
            {
                rfcDestination = RfcDestinationManager.GetDestination(destinationConfigName);
            }
        }

        public List<JobRoleResponse> GetJobRole(AttendanceRequest request)
        {
            List<JobRoleResponse> result = new List<JobRoleResponse>();
            IRfcFunction rfcFunc = rfcRepo.CreateFunction("ZRF_GET_JOB_ROLES");
            rfcFunc.SetValue("I_EPF", request.Epf);
            rfcFunc.SetValue("I_WERKS", request.Plant);

            rfcFunc.Invoke(rfcDestination);

            // Read RFC return Table
            IRfcTable TAB_JOB = rfcFunc.GetTable("E_JOB_ROLES");

            foreach (IRfcStructure row in TAB_JOB)
            {
                JobRoleResponse obj = new JobRoleResponse();
                obj.Role = row.GetValue("SEC_TYPE").ToString().Trim();
                obj.UserName = row.GetValue("NAME").ToString().Trim();
                result.Add(obj);
            }
            return result;
        }
    }
}
