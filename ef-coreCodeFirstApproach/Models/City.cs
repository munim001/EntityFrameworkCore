using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Models
{
    [Table("Tbl_City")]
    public class City
    {
        [Column("CityId", TypeName = "int")]
        [Key]
        public int Id { get; set; }

        [Column("CityName", TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        
    }
}
