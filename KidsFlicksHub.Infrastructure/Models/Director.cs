using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class Director
	{
		[Key]
		[Comment("Id for a Director")]
        public int Id { get; set; }
		[Required]
		[MaxLength(DirectorFullNameMaxLength)]
		[Comment("Full name for a director")]
		public string FullName { get; set; } = string.Empty;

        [Required]
		[Comment("Date of birth for an director")]
        public DateTime DiteOfBirth { get; set; }

		[Required]
		[MaxLength(DirectorBiographyMaxLength)]
		[Comment("Biography")]
        public string Biography { get; set; } =string.Empty;

        [Required]
        public string PhotoUrl { get; set; }

        [Required]
        public int MovieId { get; set; }
		[ForeignKey(nameof(MovieId))]
		public Movie Movie { get; set; } = null!;

        [Required]
        public int ActorId { get; set; }
		[ForeignKey(nameof(ActorId))]
		public Actor Actor { get; set; } = null!;

		public ICollection<Movie> Movies { get; set; } = new List<Movie>();
		
    }
}
