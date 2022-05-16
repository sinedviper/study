using System.Collections.Generic;

namespace Models.Entities
{
    public class Genre : BaseEntity
    {
        // параметры для жанра
        public string Title { get; set; }

        public int Rating { get; set; }

        public long AvgSize { get; set; }

        public virtual ICollection<Comics> Comics { get; set; }
    }
}
