using System.ComponentModel.DataAnnotations;
using Skolquiz_frontend.Models;

namespace Skolquiz_frontend.Models
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

