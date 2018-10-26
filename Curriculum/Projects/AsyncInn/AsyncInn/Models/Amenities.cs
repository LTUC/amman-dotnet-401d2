using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
	public class Amenities
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }

		ICollection<RoomAmenities> RoomAmenities { get; set; }
	}
}
