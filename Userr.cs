using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce1.Models
{
    public partial class Userr
    {
		public Userr()
		{
			Carts = new HashSet<Cart>();
		}
		[Key]
		public int UserId { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public string? Passward { get; set; }

		public virtual ICollection<Cart> Carts { get; set; }
	}
}
