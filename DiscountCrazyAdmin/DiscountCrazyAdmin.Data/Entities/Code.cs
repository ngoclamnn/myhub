namespace DiscountCrazyAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Code()
        {
            CodeUsedHistories = new HashSet<CodeUsedHistory>();
            PromotionCodes = new HashSet<PromotionCode>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Column("code")]
        [Required]
        [StringLength(12)]
        public string code1 { get; set; }

        public double discount_value { get; set; }

        public int discount_type_id { get; set; }

        public bool is_active { get; set; }

        public bool is_onhold { get; set; }

        public bool is_public { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime modified { get; set; }

        [Required]
        [StringLength(50)]
        public string modified_by { get; set; }

        public virtual DiscountType DiscountType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeUsedHistory> CodeUsedHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionCode> PromotionCodes { get; set; }
    }
}
