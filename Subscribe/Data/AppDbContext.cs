using Microsoft.EntityFrameworkCore;
using Subscribe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscribe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) {}
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}
