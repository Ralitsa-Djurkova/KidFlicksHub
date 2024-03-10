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
			
			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new ActorConfiguration());
			builder.ApplyConfiguration(new CategoryConfiguration());
			builder.ApplyConfiguration(new MovieConfiguration());
			builder.ApplyConfiguration(new DirectorConfiguration());



			base.OnModelCreating(builder);
		}


	}
}
