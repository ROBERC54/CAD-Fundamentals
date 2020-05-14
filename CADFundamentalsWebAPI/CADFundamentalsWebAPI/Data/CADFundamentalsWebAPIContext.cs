using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CADFundamentalsWebAPI.Models;

namespace CADFundamentalsWebAPI.Data
{
    public class CADFundamentalsWebAPIContext : DbContext
    {
        public CADFundamentalsWebAPIContext(DbContextOptions<CADFundamentalsWebAPIContext> options)
            : base(options)
        { 
        }
        public DbSet<UberCategory> UberCategory { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
