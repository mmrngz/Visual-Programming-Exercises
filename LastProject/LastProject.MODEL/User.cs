using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.MODEL
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public DateTime AddDateTime { get; set; }

		public int RoleId { get; set; }
		public virtual
	}
}
