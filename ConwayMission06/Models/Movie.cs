using System.ComponentModel.DataAnnotations;

namespace ConwayMission06.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Conventions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    //movie class
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Year is required")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be at least 1888")]
        public int Year { get; set; } = DateTime.UtcNow.Year;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Edited is required")]
        public bool Edited { get; set; }
        [Required(ErrorMessage = "CopiedToPlex is required")]
        public bool CopiedToPlex { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
