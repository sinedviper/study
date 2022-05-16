using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Website.Models {
    //описываем поля которые будут получать значение из html страницы
    public class ComicsViewModel {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required, DisplayName("Genre")]
        public int GenreId { get; set; }

        [Required]
        public GenreViewModel Genre { get; set; }

        [Required, DisplayName("Studio")]
        public int StudioId { get; set; }

        [Required]
        public StudioViewModel Studio { get; set; }
    }
}
