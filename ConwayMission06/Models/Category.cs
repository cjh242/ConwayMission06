using System.ComponentModel.DataAnnotations;

namespace ConwayMission06.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
