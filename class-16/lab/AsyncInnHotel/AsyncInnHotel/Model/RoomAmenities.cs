namespace AsyncInnHotel.Model
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }

        public int RoomID { get; set; }

        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}
