using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce1.Models
{
    public partial class Cart
    {
		[Key]
		public int CartId { get; set; }
		[ForeignKey("Userr")]
		public int? UserId { get; set; }
		[ForeignKey("Product")]
		public int? ProductId { get; set; }
		public int? Quanatity { get; set; }

		public virtual Product? Product { get; set; }
		public virtual Userr? Userr { get; set; }
	}
}
