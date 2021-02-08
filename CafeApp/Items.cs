namespace CafeApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? Item { get; set; }

        public int? ItemGroup { get; set; }
        public double Price { get; set; }

    }
}
