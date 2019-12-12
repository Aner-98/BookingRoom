using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingRoom.Models
{
	public class Ivent
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IventType Type { get; set; }
	}
}
