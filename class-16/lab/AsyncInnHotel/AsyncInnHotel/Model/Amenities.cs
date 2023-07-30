namespace AsyncInnHotel.Model
{
    public class Amenities
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<RoomAmenities> RoomAmenities { get; set; }
    }
}
