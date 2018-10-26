using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
	public class Hotel
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

		public ICollection<HotelRoom> Rooms { get; set; }
	}
}
	