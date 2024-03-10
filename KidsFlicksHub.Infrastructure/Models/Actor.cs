using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class Actor
	{
        public int Id { get; set; }
        [Required]
        [MaxLength(ActorFullNameMaxLength)]
        [Comment("Actor full name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("DateOfBirth of Birth an actor")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(ActorBiographyMaxLength)]
        [Comment("Biography for every actor")]
        public string Biography { get; set; } = string.Empty;

        [Required]
        public string PhotoUrl { get; set; } = string.Empty;

        public int MovieId { get; set; }
        [Required]
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
		
		public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
