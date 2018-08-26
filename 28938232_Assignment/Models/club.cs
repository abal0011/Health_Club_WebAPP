namespace _28938232_Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("club")]
    public partial class club
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }
    }
}
