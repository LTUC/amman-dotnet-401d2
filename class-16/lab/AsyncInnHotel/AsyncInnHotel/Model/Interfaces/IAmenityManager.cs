using AsyncInn.Models.DTOs;
using AsyncInnHotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenityManager
    {
        Task<Amenities> CreateAmenity(Amenities amenity);
        Task DeleteAmentity(int id);
        Task<List<Amenities>> GetAmenities();
        Task<Amenities> GetAmentity(int id);
    }
}