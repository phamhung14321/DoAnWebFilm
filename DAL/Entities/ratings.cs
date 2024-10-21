namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ratings
    {
        [Key]
        public int rating_id { get; set; }

        public int? user_id { get; set; }

        public int? movie_id { get; set; }

        public decimal? rating { get; set; }

        [Column(TypeName = "text")]
        public string review { get; set; }

        public DateTime? rating_date { get; set; }

        public virtual movies movies { get; set; }

        public virtual users users { get; set; }
    }
}
