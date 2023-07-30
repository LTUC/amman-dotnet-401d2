using AsyncInn.Models.Interfaces;
using AsyncInnHotel.Data;
using Microsoft.EntityFrameworkCore;

namespace AsyncInnHotel.Model.Services
{
    public class AmenityService : IAmenityManager
    {
        private HotelDbContext _context;
        public AmenityRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Amenities> CreateAmenity(Amenities amenity)
        {
            // convert the amenityDTO to an actual entity

            Amenities entity = new Amenities()
            {
                Name = amenity.Name
            };

            _context.Entry(entity).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return amenity;
        }

        public async Task DeleteAmentity(int id)
        {
            var amenenity = await GetAmentity(id);
            _context.Entry(amenenity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public async Task<List<AmenityDTO>> GetAmenities()
        {
            var list = await _context.Amenities.ToListAsync();

            var amenities = new List<AmenityDTO>();

            foreach (var item in list)
            {
                amenities.Add(await GetAmentity(item.ID));
            }

            return amenities;
        }

        public async Task<Amenities> GetAmentity(int id)
        {
            // our DB does NOT hold DTOs. It holds enitites.
            Amenities amenity = await _context.Amenities.FindAsync(id);

           

            return amenity;
        }

    }
}
