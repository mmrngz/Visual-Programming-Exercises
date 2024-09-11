using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.MODEL
{
	public class Vehicle : IEntity
	{

		public int Id { get; set; }		
		public int BrandId { get; set; }	
		public string Color { get; set; }	
		public decimal Price { get; set; }
		public string Model { get; set; }	
		public string CarSafeType { get; set; }	
		public int ModelYear { get; set; }
		public bool IsOnSale { get; set; }	
		public string Notes { get; set; }	
		public virtual Brand Brand { get; set; }		

	}
}
