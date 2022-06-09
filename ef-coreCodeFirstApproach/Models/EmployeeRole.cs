using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Models
{
    public class EmployeeRole
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }


        public int RoleId { get; set; }

        public Role Role { get; set; }

        
    }
}
