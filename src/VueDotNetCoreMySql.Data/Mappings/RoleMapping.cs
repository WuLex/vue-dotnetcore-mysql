﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VueDotNetCoreMySql.Common.Entities;

namespace VueDotNetCoreMySql.Data.Mappings
{
    class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.RoleId);
            builder.Property(x => x.RoleName).IsRequired().HasMaxLength(25);
            builder.Property(x => x.RoleDescription).HasMaxLength(50);
        }
    }
}