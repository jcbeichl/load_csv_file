using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week.one.empployee.data
{
    public class ManagerData:EmployeeData
    {
        public string CostCenter { get; set; }
        public string ManagerSupervisor { get; set; }
    }
}
