using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;




namespace JTI.Models
{
    public class ContextoDb : DbContext
    {
        
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
