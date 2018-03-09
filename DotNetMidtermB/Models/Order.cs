namespace DotNetMidtermB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderId { get; set; }

        public int SizeId { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        public virtual Size Size { get; set; }
    }
}
