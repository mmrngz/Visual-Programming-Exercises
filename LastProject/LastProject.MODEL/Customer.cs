using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.MODEL
{
	public class Customer : IEntity
	{
		public int Id { get; set; }
		public int BrandId { get; set; }	
		public string Name { get; set; }	
		public string Surname { get; set; }
		public string TCNo { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }	
		public string PhoneNumber { get; set; }
		public string Notes { get; set; }	
		public virtual Brand Brand { get; set; }	

	}
}
