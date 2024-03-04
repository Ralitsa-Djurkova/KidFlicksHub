using KidsFlicksHub.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KidsFlicksHub.Infrastructure.Data.SeedData
{
	internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder
				.HasOne(m => m.Category)
				.WithMany(c => c.Movies)
				.HasForeignKey(m => m.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			var data = new SeedData();
			DataBuilder<Movie> databuilder = builder.HasData(new Movie[] {data.Movie});
		}
	}
}
