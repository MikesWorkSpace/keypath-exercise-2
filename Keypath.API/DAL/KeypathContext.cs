using Keypath.API.MigrationSupport;
using Keypath.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keypath.API.DAL
{
    public class KeypathContext : DbContext
    {
        public KeypathContext(DbContextOptions<KeypathContext> options) 
            : base(options)
        {

        }

        public DbSet<ExampleItem> ExampleItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SeedExampleItems());

        }
    }
}
