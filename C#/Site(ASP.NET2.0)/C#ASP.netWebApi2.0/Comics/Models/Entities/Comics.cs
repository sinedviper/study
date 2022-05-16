using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Comics : BaseEntity
    {
        // параметры для комикса
        public string Title { get; set; }

        public double Price { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public int StudioId { get; set; }

        public virtual Studio Studio { get; set; }
    }
}
