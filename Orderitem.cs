using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Models
{
    public partial class Orderitem
    {
		public int OrderitemId { get; set; }
		[ForeignKey("Order")]
		public int? OrderId { get; set; }
		[ForeignKey("Product")]
		public int? ProductId { get; set; }
		public int? Quantity { get; set; }
		public decimal? Price { get; set; }

		public virtual Order? Order { get; set; }
		public virtual Product? Product { get; set; }
	}
}
