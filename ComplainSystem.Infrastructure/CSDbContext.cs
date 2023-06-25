using ComplainSystem.DomainModelCore.CoreEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Infrastructure
{
    public class CSDbContext : DbContext
    {
        public CSDbContext(DbContextOptions<CSDbContext> options) : base(options)
        {

        }

        public DbSet<UserRegistartion> UserRegistration { get; set; }
    }
}
