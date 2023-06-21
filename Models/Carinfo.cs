using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.Build.Evaluation;

namespace Cardekho.Models
{
	public class Carinfo
	{
        public int CarinfoId { get; set; }

       
        public int Quantity { get; set; }

        
        public decimal Price { get; set; }

       
        public string CustomerId { get; set; }

  
        public int InventoryId { get; set; }

        //Parent 

        public Inventory Inventory { get; set; } = default;

    }

}