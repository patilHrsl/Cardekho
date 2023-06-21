using System;
using System.ComponentModel.DataAnnotations;
namespace Cardekho.Models
{
	public class Orderdetail
	{
        public int OrderDetailId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int InventoryId { get; set; }

        //Parent relation
        public Order Order { get; set; } = default;

    }
}

