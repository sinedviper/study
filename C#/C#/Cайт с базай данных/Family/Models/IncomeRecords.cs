using System;
using System.ComponentModel.DataAnnotations;

namespace Family.Models {
    public class IncomeRecords {

        public int Id { get; set; }
        public int IncomeCategoryId { get; set; }

        [Display(Name = "ExpensesRecords date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime IncomeRecordss { get; set; }
        public int Value { get; set; }
        public string Information { get; set; }

        public virtual IncomeCategory IncomeCategory { get; set; }
    }
}