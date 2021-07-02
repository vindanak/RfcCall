using SAP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP
{
    class Program
    {
        static void Main(string[] args)
        {
            RfcCallManager rfcCall = new RfcCallManager();
            List<JobRoleResponse> responses = rfcCall.GetJobRole(new AttendanceRequest() { Epf = "151", Plant = "A052" });
        }
    }
}
