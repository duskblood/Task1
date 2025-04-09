using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Название фильма обязательно")]
        [StringLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Жанр обязателен")]
        [StringLength(50, ErrorMessage = "Жанр не должен превышать 50 символов")]
        public string Genre { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Год выпуска обязателен")]
        [Range(1900, 2100, ErrorMessage = "Год должен быть между 1900 и 2100")]
        public int Year { get; set; }
        
        [Required(ErrorMessage = "Рейтинг обязателен")]
        [Range(1, 10, ErrorMessage = "Рейтинг должен быть от 1 до 10")]
        public double Rating { get; set; }
    }
} 