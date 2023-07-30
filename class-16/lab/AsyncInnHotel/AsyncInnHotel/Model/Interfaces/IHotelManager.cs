﻿namespace AsyncInnHotel.Model.Interfaces
{
    public interface IHotelManager
    {
        Task<Hotel> CreateHotel(Hotel hotel);
        Task UpdateHotel(Hotel hotel);
        Task DeleteHotel(int id);
        Task<List<Hotel>> GetHotels();
        Task<Hotel> GetHotel(int id);
    }
}
