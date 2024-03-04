using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class User : IdentityUser
	{
		[Key]
		[Comment("Id for the user")]
		public int Id { get; set; }
		[Required]
		[MaxLength(UserNameMaxLength)]
		[Comment("User name")]
		public string Name { get; set; } = string.Empty;

		[Required]
		[MaxLength(UserPasswordMaxLength)]
		[Comment("Password for the user")]
		public string Password { get; set; } = string.Empty;

		[Required]
		[Comment("user email")]
		public string Email { get; set; } = string.Empty;
		[Required]
		[Comment("The role of user")]
		public string UserRole { get; set; } = string.Empty;

        [Required]
        public int MovieId { get; set; }
		[ForeignKey(nameof(MovieId))]
		public Movie Movie { get; set; } = null!;

		public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}
