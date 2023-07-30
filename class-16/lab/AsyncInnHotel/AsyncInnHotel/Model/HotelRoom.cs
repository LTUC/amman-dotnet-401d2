namespace AsyncInnHotel.Model
{
    public class HotelRoom
    {
  
        public int HotelID { get; set; }

        public int RoomID { get; set; }

        public int RoomNumber { get; set; }

        public decimal Rate { get; set; }

        public bool PetFriendly { get; set; }

        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
    }
}
