using Microsoft.EntityFrameworkCore;
using SharpTamagochi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpTamagochi.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Ufo> Ufos { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Trick> Tricks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
