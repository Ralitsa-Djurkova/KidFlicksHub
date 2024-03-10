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
    internal class ActorInMovieConfoguration : IEntityTypeConfiguration<ActorInMovieConfoguration>
    {
        public void Configure(EntityTypeBuilder<ActorInMovieConfoguration> builder)
        {
            var data = new SeedData();
            builder.HasData(new ActorIsInMovie { data.Movie, data.Actor});
        }
    }
}
