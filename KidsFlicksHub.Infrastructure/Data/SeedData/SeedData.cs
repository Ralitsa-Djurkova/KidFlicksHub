using KidsFlicksHub.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFlicksHub.Infrastructure.Data.SeedData
{
	internal class SeedData
	{
		public IdentityUser AdminUser { get; set; }
		public IdentityUser GuestUser { get; set; }

        public Director Director { get; set; }
        public Movie Movie { get; set; }

		public Actor Actor { get; set; }
		public Category BulgarianCategory { get; set; }
		public Category ForeignCategory { get; set; }

        public SeedData()
        {
			SeedUser();
			SeedCategory();
			
        }
        private void SeedUser()
		{
			var hasher = new PasswordHasher<IdentityUser>();

			AdminUser = new IdentityUser()
			{
				Id = "dea12856-c198-4129-b3f3-b893d8395082",
				UserName = "admin@mail.com",
				NormalizedUserName = "admin@mail.com",
				Email = "admin@mail.com",
				NormalizedEmail = "admin@mail.com"
			};

			AdminUser.PasswordHash =
				hasher.HashPassword(AdminUser, "admin123");

			GuestUser = new IdentityUser()
			{
				Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
				UserName = "guest@mail.com",
				NormalizedUserName = "guest@mail.com",
				Email = "guest@mail.com",
				NormalizedEmail = "guest@mail.com"
			};

			GuestUser.PasswordHash =
				hasher.HashPassword(GuestUser, "guest123");
		}
		

		private void SeedCategory()
		{
			BulgarianCategory = new Category()
			{
				Id = 1,
				Name = "Bg category",
				
			};

			ForeignCategory = new Category()
			{
				Id = 2,
				Name = "Foreign category"
			};
		}
	}
}
