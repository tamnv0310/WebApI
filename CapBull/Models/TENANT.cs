using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapBull.Models
{
    public class TENANT
    {
        [Key]
        public int TenantID { get; set; }
        public string Name { get; set; }
    }
}
