using System.ComponentModel.DataAnnotations;

namespace ConwayMission06.Models
{
    using System.ComponentModel.DataAnnotations;

    //movie class
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        public string? Edited { get; set; }
        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
