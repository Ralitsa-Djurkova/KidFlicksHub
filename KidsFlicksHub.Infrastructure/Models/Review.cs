using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class Review
	{

        [Required]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;

        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        [Range(1, 10)]
        public double Rating { get; set; }

        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; } = string.Empty;
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string ParticipantId { get; set; } = string.Empty;
        [ForeignKey(nameof(ParticipantId))] 
        public IdentityUser? Participant { get; set; }

    }
}
