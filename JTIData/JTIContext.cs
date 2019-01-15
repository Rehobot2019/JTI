using Microsoft.EntityFrameworkCore;
using System;

namespace JTIData
{
    public class JTIContext : DbContext
    {
        public JTIContext(DbContextOptions options) : base(options) { }
        public DbSet<Conductores> Conductores { get; set; }


    }
}
