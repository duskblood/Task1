using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Genre { get; set; } = string.Empty;
        
        [Required]
        [Range(1900, 2100)]
        public int Year { get; set; }
        
        [Required]
        [Range(0, 10)]
        public double Rating { get; set; }
    }
} 