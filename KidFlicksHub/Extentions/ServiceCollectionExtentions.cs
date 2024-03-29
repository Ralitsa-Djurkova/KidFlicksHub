﻿using KidFlicksHub.Data;
using KidsFlicksHub.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extentions.DependencyInjection
{
	public static class ServiceCollectionExtentions
	{
		public static  IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			
			return services;
		}
		public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection");
			services.AddDbContext<KidFlicksDbContext>(options =>
				options.UseSqlServer(connectionString));

			services.AddDatabaseDeveloperPageExceptionFilter();
			return services;
		}
		public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
		{
			services.AddDefaultIdentity<IdentityUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = false;
				options.Password.RequireDigit = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireLowercase = false;
				options.Password.RequireUppercase = false;
			})
			   .AddEntityFrameworkStores<KidFlicksDbContext>();
			return services;
		}
	}

	
}
