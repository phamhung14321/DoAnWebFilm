namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admins
    {
        [Key]
        public int admin_id { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string role { get; set; }

        public virtual users users { get; set; }
    }
}
