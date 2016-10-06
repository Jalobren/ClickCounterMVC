namespace ClickCounter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClickCounter")]
    public partial class ClickCounterModel
    {
        public int Id { get; set; }

        [Range(0, 10, ErrorMessage = "You've reached the max value")]
        public int Count { get; set; }
    }
}
