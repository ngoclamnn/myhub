namespace DiscountCrazyAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            Promotions = new HashSet<Promotion>();
        }

        public int id { get; set; }

        public int user_id { get; set; }

        public int? business_category_id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(500)]
        public string address { get; set; }

        [StringLength(500)]
        public string address2 { get; set; }

        [Required]
        [StringLength(250)]
        public string country { get; set; }

        [StringLength(250)]
        public string state { get; set; }

        [Required]
        [StringLength(250)]
        public string suburb { get; set; }

        [Required]
        [StringLength(50)]
        public string postcode { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        public double? lat { get; set; }

        public double? lng { get; set; }

        [StringLength(500)]
        public string formatted_address { get; set; }

        [StringLength(10)]
        public string security_key { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime modified { get; set; }

        [Required]
        [StringLength(50)]
        public string modified_by { get; set; }

        public virtual BusinessCategory BusinessCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotions { get; set; }

        public virtual User User { get; set; }
    }
}
