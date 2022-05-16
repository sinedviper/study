namespace Business.DTOs {
    //здесь описываем строки с которыми будем взаимодействовать в форме
    public class StudioDto : BaseDto, IValidateable {
        public string Title { get; set; }

        public string Country { get; set; }

        public int Employees { get; set; }

        public double Capitalization { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Title) && Title.Length < 50
                && !string.IsNullOrWhiteSpace(Country) && Country.Length < 50
                && Employees > 0 && Employees < 10000000
                && Capitalization > 0 && Capitalization < double.MaxValue;
        }
    }
}
