using System.ComponentModel.DataAnnotations;

namespace Cardekho.Models
{
    public class Inventory
	{
		public int InventoryId {get; set;}
		public String Name { get; set; }
		public String Make { get; set; }
        [Range(10, 10000)]
        public decimal price { get; set; }

        // Parent Reference
        public int CompanyId { get; set; }
        public Company Company { get; set; } = default;

        //child references
        public List<Carinfo> carinfos { get; set; } = default;
    }
}

