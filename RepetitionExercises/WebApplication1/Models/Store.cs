namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store
    {
        public int StoreId { get; set; }

        [StringLength(250)]
        public string StoreLocation { get; set; }

        [StringLength(50)]
        public string StoreTel { get; set; }

        public bool? PreferredSupplier { get; set; }
    }
}
