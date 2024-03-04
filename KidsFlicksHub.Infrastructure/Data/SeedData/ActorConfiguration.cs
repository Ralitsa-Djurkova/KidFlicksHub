using KidsFlicksHub.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFlicksHub.Infrastructure.Data.SeedData
{
	internal class ActorConfiguration : IEntityTypeConfiguration<Actor>
	{
		public void Configure(EntityTypeBuilder<Actor> builder)
		{
			var data = new SeedData();
			builder.HasData(new Actor[] {data.Actor});
		}
	}
}
