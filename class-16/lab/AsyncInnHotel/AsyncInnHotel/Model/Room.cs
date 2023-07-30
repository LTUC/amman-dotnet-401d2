using System.ComponentModel.DataAnnotations;

namespace AsyncInnHotel.Model
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }


        [EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        public List<HotelRoom> HotelRooms { get; set; }

        public List<RoomAmenities> RoomAmenities { get; set; }

    }

    public enum Layout
    {
        TwoBedSuite,
        OneBedSuite,
        Studio
    }
}
