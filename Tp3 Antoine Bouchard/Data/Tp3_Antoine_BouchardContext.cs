using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tp3_Antoine_Bouchard.Models;

namespace Tp3_Antoine_Bouchard.Data
{
    public class Tp3_Antoine_BouchardContext : DbContext
    {
        public Tp3_Antoine_BouchardContext (DbContextOptions<Tp3_Antoine_BouchardContext> options)
            : base(options)
        {
        }

        public DbSet<Tp3_Antoine_Bouchard.Models.Voyage> Voyage { get; set; } = default!;
    }
}
