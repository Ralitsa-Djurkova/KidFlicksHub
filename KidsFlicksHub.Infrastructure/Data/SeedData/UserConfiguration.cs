﻿using KidsFlicksHub.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFlicksHub.Infrastructure.Data.SeedData
{
	internal class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			var data = new SeedData();
			builder.HasData(new IdentityUser[] {data.AdminUser, data.GuestUser});
		}
	}
}
