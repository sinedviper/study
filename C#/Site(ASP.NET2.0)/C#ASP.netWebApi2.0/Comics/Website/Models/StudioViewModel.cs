using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models {
    //описываем поля которые будут получать значение из html страницы
    public class StudioViewModel {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(50)]
        public string Country { get; set; }

        [Range(0, 10000000)]
        public long Employees { get; set; }

        [Range(0, double.MaxValue)]
        public double Capitalization { get; set; }
    }
}
