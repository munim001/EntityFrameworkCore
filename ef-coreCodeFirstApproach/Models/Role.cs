using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<EmployeeRole> EmployeeRole { get; set; }
    }
}
