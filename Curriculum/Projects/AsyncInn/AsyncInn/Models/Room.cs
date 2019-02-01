using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Room Type Name:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Layout Type: ")]
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
