using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class Movie
	{
		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(MovieTitleMaxLength)]
		[Comment("Title movie")]
		public string Title { get; set; } = string.Empty;

        [Required]
		
		[Comment("Date on Release")]
        public DateTime ReleaseDate { get; set; }
		[Required]
        public int Duration { get; set; }
		[Required]
		public string Genre { get; set; } = string.Empty;

		[Required]
		[MaxLength(MovieDescriptionMaxLength)]
		[Comment("Description for the movie")]
		public string Description { get; set; } = string.Empty;

		[Required]
		public string TrailerUrl { get; set; } = string.Empty;
		[Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
		[Required]
		public int DirectorId { get; set; }
		[ForeignKey(nameof(DirectorId))]
		public Director? Director { get; set; }

        public ICollection<Actor> Actors { get; set; } = new List<Actor>();
		public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
