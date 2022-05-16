using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Studio : BaseEntity
    {
        // параметры для студии
        public string Title { get; set; }

        public string Country { get; set; }

        public int Employees { get; set; }

        public double Capitalization { get; set; }

        public virtual ICollection<Comics> Comics{ get; set; }
    }
}
