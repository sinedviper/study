using System.Collections.Generic;

namespace Family.Models {
    public class ExpensesCategory {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ExpenseRecords> ExpenseRecords { get; set; }

    }
}