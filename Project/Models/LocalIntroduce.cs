namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocalIntroduce")]
    public partial class LocalIntroduce
    {
        [Key]
        public int IntroId { get; set; }

        public int? UserId { get; set; }

        public int? LocalId { get; set; }

        public string IntroDetail { get; set; }
    }
}
