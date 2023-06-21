using System;
namespace Cardekho.Models
{
	public class Company
	{
		public int CompanyId { get; set; }

        public string Name { get; set; }

		public List<Inventory> Inventories { get; set; } = default;
    }
}


