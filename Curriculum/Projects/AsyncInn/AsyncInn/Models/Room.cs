using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
	public class Room
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		[EnumDataType(typeof(Layout))]
		public Layout Layout { get; set; }

		ICollection<HotelRoom> HotelRooms { get; set; }

		ICollection<RoomAmenities> RoomAmenities { get; set; }
	}

	public enum Layout
	{
		TwoBedSuite,
		OneBedSuite,
		Studio
	}

}
