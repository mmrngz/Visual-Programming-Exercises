using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.MODEL
{
	public class Sale :IEntity
	{
		public int Id { get; set; }	
		public int BrandId { get; set; }
		public int CustomerId { get; set; }		
		public decimal SalePrice { get; set; }	
		public DateTime SaleTime { get; set; }
		public virtual Brand Brand { get; set; }	
		public virtual Customer Customer { get; set; }	
	}
}
