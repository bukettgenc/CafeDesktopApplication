namespace CafeApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Addition")]
    public partial class Addition
    {
        public int Id { get; set; }

        public int? Item { get; set; }

        public int? TableNu { get; set; }

        public int? Count { get; set; }

    }
}
