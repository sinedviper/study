namespace Business.DTOs {
    //здесь описываем строки с которыми будем взаимодействовать в форме
    public class ComicsDto : BaseDto, IValidateable {
        public string Title { get; set; }

        public double Price { get; set; }

        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public int StudioId { get; set; }

        public StudioDto Studio { get; set; }

        public bool IsValid() {
            return !string.IsNullOrWhiteSpace(Title) && Title.Length < 50
                && Price >= 0 && Price < double.MaxValue;
        }
    }
}
