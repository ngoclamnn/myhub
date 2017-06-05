namespace DiscountCrazyAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodeUsedHistory")]
    public partial class CodeUsedHistory
    {
        public int id { get; set; }

        public int code_id { get; set; }

        public int promotion_id { get; set; }

        [Required]
        [StringLength(250)]
        public string used_by { get; set; }

        public DateTime used_date { get; set; }

        public int number_of_used { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public virtual Code Code { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
