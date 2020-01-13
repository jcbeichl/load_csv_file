using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week.one.empployee.data
{
    public class DevelopersData:EmployeeData
    {
        public string DeveloperType { get; set; }

        public string DeveloperSupervisor { get; set; }

        public string DeveloperTaxType { get; set; }
    }
}
