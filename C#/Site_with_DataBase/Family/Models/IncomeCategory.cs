using System.Collections.Generic;

namespace Family.Models {
    public class IncomeCategory {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Informations { get; set; }

        public virtual ICollection<IncomeRecords> IncomeRecords { get; set; }
    }
}