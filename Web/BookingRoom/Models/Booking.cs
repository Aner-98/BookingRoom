using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingRoom.Models
{
	public class Booking
	{
		public int Id { get; set; }
		public Room Room { get; set; }
		public IventType Ivent { get; set; }
		public DateTime Date { get; set; }
		public ApplicationUser User { get; set; }
	}
}
