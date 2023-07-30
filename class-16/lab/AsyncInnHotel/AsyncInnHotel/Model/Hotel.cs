namespace AsyncInnHotel.Model
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public List<HotelRoom> HotelRooms { get; set; }
    }
}
