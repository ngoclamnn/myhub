namespace DiscountCrazyAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PromotionCode
    {
        public int id { get; set; }

        public int promotion_id { get; set; }

        public int code_id { get; set; }

        public virtual Code Code { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
