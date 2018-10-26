using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Data
{
	public class HotelDbContext : DbContext
	{
		public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<HotelRoom>().HasKey(hr => new { hr.HotelID, hr.RoomNumber });

			modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.RoomID, ce.AmenitiesID });

			modelBuilder.Entity<Room>().HasData(
				new Room { ID = 1, Name = "Seahawks Snooze", Layout = Layout.TwoBedSuite },
				new Room { ID = 2, Name = "Restful Rainier", Layout = Layout.TwoBedSuite },
				new Room { ID = 3, Name = "Couples Retreat", Layout = Layout.OneBedSuite },
				new Room { ID = 4, Name = "Officially Business", Layout = Layout.Studio }
				);

			modelBuilder.Entity<Hotel>().HasData(
				new Hotel { ID = 1, Name = "Emerald City Stay", Address = "123 Seattle Way", Phone = "123-456-7654" },
				new Hotel { ID = 2, Name = "Las Vegas Strip", Address = "123 LasVegas Strip Way", Phone = "123-876-1946" },
				new Hotel { ID = 3, Name = "Disney Adventures", Address = "987 Dizney Way", Phone = "481-512-3421" }
				);
		}

		public DbSet<Hotel> Hotels { get; set; }

		public DbSet<HotelRoom> HotelRooms { get; set; }

		public DbSet<Room> Rooms { get; set; }

		public DbSet<Amenities> Amenities { get; set; }

		public DbSet<RoomAmenities> RoomAmenities { get; set; }


	}
}
