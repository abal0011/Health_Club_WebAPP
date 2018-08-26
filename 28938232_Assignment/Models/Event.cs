namespace _28938232_Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column("Event")]
        [StringLength(50)]
        public string Event1 { get; set; }

        [Column(TypeName = "text")]
        public string detail { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }
    }
}
