namespace L04E02.Books.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Title
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Title()
        {
            Authors = new HashSet<Author>();
        }

        [Key]
        [StringLength(50)]
        public string ISBN { get; set; }

        [Column("Title")]
        [StringLength(50)]
        public string Title1 { get; set; }

        public int? EditionNumber { get; set; }

        [StringLength(50)]
        public string Copyright { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
