using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingRoom.Models
{
	public class IventReport
	{
		public int Id { get; set; }
		public Ivent Ivent { get; set; }
		public ApplicationUser User { get; set; }
		public string Report { get; set; }
	}
}
