using Keypath.API.MigrationSupport.BaselineData;
using Keypath.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keypath.API.MigrationSupport
{
    public class SeedExampleItems : IEntityTypeConfiguration<ExampleItem>
    {
        public void Configure(EntityTypeBuilder<ExampleItem> builder)
        {
            builder.ToTable("ExampleItem");

            var seeds = BaselineExampleItems.GetData();
            foreach (var seed in seeds)
            {
                builder.HasData(seed);
            }
        }

    }
}
