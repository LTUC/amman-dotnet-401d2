using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    interface IHotelManager
    {
        void CreateHotel();
        void UpdateHotel(int id);
        void DeleteHotel(int id);
        List<Hotel> GetHotels();
        Room GetHotel(int id);

    }
}
