﻿using KidsFlicksHub.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFlicksHub.Infrastructure.Data.SeedData
{
	internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			var data = new SeedData();
			builder.HasData(new Category[] {data.BulgarianCategory, data.ForeignCategory});
		}
	}
}
