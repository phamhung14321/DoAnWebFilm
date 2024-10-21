namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movies()
        {
            ratings = new HashSet<ratings>();
        }

        [Key]
        public int movie_id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [StringLength(100)]
        public string genre { get; set; }

        public int? release_year { get; set; }

        [StringLength(100)]
        public string director { get; set; }

        [StringLength(255)]
        public string image_url { get; set; }

        [StringLength(255)]
        public string video_url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ratings> ratings { get; set; }
    }
}
