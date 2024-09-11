using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.MODEL
{
	public class Service: IEntity
	{
		public int Id { get; set; }	
		public DateTime InServiceTime { get; set; }	
		public string VehicleProblem { get; set; }	
		public decimal ServicePrice { get; set; }	
		public DateTime OutServiceTime { get; set; }
		public string TransactionMade { get; set;}
		public bool IsUnderWarranty { get; set; }
		public string VehiclePlate { get; set; }
		public string Brand { get; set; }	
		public string Model { get; set; }
		public string CarSafeType { get; set; } 
		public string ChassisNo { get; set; } 
		public string Notes { get; set; }



	}
}
