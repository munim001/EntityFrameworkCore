using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Models
{
    public class Vehicle
    {
        public int VId { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public Employee Employee { get; set; }
    }
}
