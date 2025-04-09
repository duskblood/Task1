using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class MovieViewModel
    {
        [Required(ErrorMessage = "Название фильма обязательно")]
        [StringLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
        [Display(Name = "Название")]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Жанр обязателен")]
        [StringLength(50, ErrorMessage = "Жанр не должен превышать 50 символов")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Год выпуска обязателен")]
        [Range(1900, 2100, ErrorMessage = "Год должен быть между 1900 и 2100")]
        [Display(Name = "Год выпуска")]
        public int Year { get; set; }
        
        [Required(ErrorMessage = "Рейтинг обязателен")]
        [Range(1, 10, ErrorMessage = "Рейтинг должен быть от 1 до 10")]
        [Display(Name = "Рейтинг")]
        public double Rating { get; set; }
    }
} 