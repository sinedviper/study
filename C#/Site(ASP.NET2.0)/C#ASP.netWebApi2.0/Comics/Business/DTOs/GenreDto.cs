namespace Business.DTOs {
    //здесь описываем строки с которыми будем взаимодействовать в форме
    public class GenreDto : BaseDto, IValidateable {
        public string Title { get; set; }

        public int Rating { get; set; }

        public long AvgSize { get; set; }

        public bool IsValid() {
            return !string.IsNullOrWhiteSpace(Title) && Title.Length < 50
                && Rating >= 0 && Rating <= 10 
                && AvgSize >= 0 && AvgSize < long.MaxValue;
        }
    }
}
