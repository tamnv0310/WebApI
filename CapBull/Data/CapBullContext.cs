using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapBull.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CapBull.Models
{
    public class CapBullContext : IdentityDbContext<Tenants>
    {
        public CapBullContext (DbContextOptions<CapBullContext> options)
            : base(options)
        {
        }
        
       
    }
}
