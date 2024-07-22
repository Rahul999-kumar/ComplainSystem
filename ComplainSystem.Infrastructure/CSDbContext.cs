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

        //public DbSet<BaseEntities> BaseEntities { get; set; }
        public DbSet<UserRegistartion> UserRegistration { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<DocumentMaster> DocumentMaster { get; set; }
        public DbSet<SocietyMaster> SocietyMaster { get; set; }
        public DbSet<TowerMaster> TowerMaster { get; set; }
        public DbSet<FloorMaster> FloorMaster { get; set; }
        public DbSet<FlatMaster> FlatMaster { get; set; }

    }
}
