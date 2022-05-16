using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    // параметры для всех значений
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
