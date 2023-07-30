﻿// <auto-generated />
using AsyncInnHotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AsyncInnHotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230730091520_SeedingDataInAmenitiesTabel")]
    partial class SeedingDataInAmenitiesTabel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AsyncInnHotel.Model.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Coffee Maker"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Netflix"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Petting Zoo"
                        });
                });

            modelBuilder.Entity("AsyncInnHotel.Model.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Seattle Way",
                            Name = "Emerald City Stay",
                            Phone = "123-456-7654"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 LasVegas Strip Way",
                            Name = "Las Vegas Strip",
                            Phone = "123-876-1946"
                        },
                        new
                        {
                            Id = 3,
                            Address = "987 Dizney Way",
                            Name = "Disney Adventures",
                            Phone = "481-512-3421"
                        },
                        new
                        {
                            Id = 4,
                            Address = "84 Treasure Way",
                            Name = "Pirates Life",
                            Phone = "975-588-9621"
                        },
                        new
                        {
                            Id = 5,
                            Address = "123 Fancy Way",
                            Name = "Grand Excursion",
                            Phone = "493-396-9785"
                        });
                });

            modelBuilder.Entity("AsyncInnHotel.Model.HotelRoom", b =>
                {
                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "Seahawks Snooze"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 0,
                            Name = "Restful Rainier"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "Couples Retreat"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 2,
                            Name = "Officially Business"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 0,
                            Name = "The Playhouse"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 1,
                            Name = "The Staycation"
                        });
                });

            modelBuilder.Entity("AsyncInnHotel.Model.RoomAmenities", b =>
                {
                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("AmenitiesID")
                        .HasColumnType("int");

                    b.HasKey("RoomID", "AmenitiesID");

                    b.HasIndex("AmenitiesID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.HotelRoom", b =>
                {
                    b.HasOne("AsyncInnHotel.Model.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsyncInnHotel.Model.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInnHotel.Model.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsyncInnHotel.Model.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenities");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.Amenities", b =>
                {
                    b.Navigation("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.Hotel", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("AsyncInnHotel.Model.Room", b =>
                {
                    b.Navigation("HotelRooms");

                    b.Navigation("RoomAmenities");
                });
#pragma warning restore 612, 618
        }
    }
}
