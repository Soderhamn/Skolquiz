using System.ComponentModel.DataAnnotations;

namespace Skolquiz_frontend.Models
{
    public class Question
{
            public int Id { get; set; }

            [Required]
            public string? QuestionText { get; set; }
            [Required]
            public string? Alternative1 { get; set; }

            [Required] //Obligatoriskt att ha med fråga + minst två svaralternativ
            public string? Alternative2 { get; set; }
            public string? Alternative3 { get; set; }
            public string? Alternative4 { get; set; }

            [Required]
            public int Correct { get; set; } //Korrekt svarsalternativ lagras som heltal

            public int CategoryId { get; set; }
            public Category? Category { get; set; } //Koppla ihop fråga med kategori

    }
}
