using System.ComponentModel.DataAnnotations;
using Admin_webbplats.Models;

namespace Admin_webbplats.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Description { get; set; }
		public List<Question>? Questions { get; set; } //Koppla ihop kategori med frågor

	}
}
