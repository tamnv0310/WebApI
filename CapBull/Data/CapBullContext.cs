using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapBull.Models;

namespace CapBull.Models
{
    public class CapBullContext : DbContext
    {
        public CapBullContext (DbContextOptions<CapBullContext> options)
            : base(options)
        {
        }

       
    }
}
