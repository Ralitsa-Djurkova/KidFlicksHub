using KidsFlicksHub.Infrastructure.Data.SeedData;
using KidsFlicksHub.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KidsFlicksHub.Infrastructure
{
	public class KidFlicksDbContext : IdentityDbContext
	{

        public KidFlicksDbContext(DbContextOptions<KidFlicksDbContext> options)
            :base(options) 
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Userses { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Review> Reviews { get; set; }

		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			//builder.Entity<Review>()
			//  .HasKey(r => new { r.MovieId, r.UserId, r.ParticipantId });

			//builder.Entity<Review>()
			//	.HasOne(x => x.User)
			//	.WithMany(x => x.Reviews)
			//	.HasForeignKey(x => x.UserId);

			//builder.Entity<Review>()
			//	.HasOne(x => x.Movie)
			//	.WithMany(x => x.Reviews)
			//	.HasForeignKey(x => x.MovieId);

			//builder.Entity<Actor>()
			//	.HasOne(a => a.Movie)
			//	.WithMany()
			//	.HasForeignKey(a => a.MovieId)
			//	.OnDelete(DeleteBehavior.NoAction);


			//builder
			//	.Entity<Category>()
			//	.HasData(new Category()
			//	{
			//		Id = 1,
			//		Name = "BG movies"
			//	},
			//	new Category()
			//	{
			//		Id = 2,
			//		Name = "Foreign movies"
			//	});
			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new ActorConfiguration());
			builder.ApplyConfiguration(new CategoryConfiguration());
			builder.ApplyConfiguration(new MovieConfiguration());
			builder.ApplyConfiguration(new DirectorConfiguration());



			base.OnModelCreating(builder);
		}


	}
}
