using System.ComponentModel.DataAnnotations;

namespace Website.Models {
    //описываем поля которые будут получать значение из html страницы
    public class GenreViewModel {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }
        
        [Required, Range(0, 10)]
        public int Rating { get; set; }

        [Required, Range(0, long.MaxValue)]
        public long AvgSize { get; set; }
    }
}
