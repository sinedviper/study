using System;
using System.ComponentModel.DataAnnotations;

namespace Family.Models {
    public class ExpenseRecords {

        public int Id { get; set; }
        public int ExpensesCategoryId { get; set; }

        [Display(Name = "ExpensesRecords date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime ExpensesRecords { get; set; }
        public int Value { get; set; }
        public string Details { get; set; }

        public virtual ExpensesCategory ExpensesCategory { get; set; }
    }
}