using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static KidsFlicksHub.Infrastructure.DataConstants;
namespace KidsFlicksHub.Infrastructure.Models
{
	public class Category
	{
		[Key]
		[Comment("Category id")]
		public int Id { get; set; }

		[Required]
		[MaxLength(CategoryNameMaxLength)]
		[Comment("Category name")]
		public string Name { get; set; } = string.Empty;

		public ICollection<Movie> Movies { get; set; } = null!;
	}
}
