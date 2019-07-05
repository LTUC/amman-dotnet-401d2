﻿// <auto-generated />
using CMSDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMSDemo.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20190705225100_newSeededData")]
    partial class newSeededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSDemo.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Content = "Hello beautiful wonderful world!",
                            Title = "Hello World"
                        },
                        new
                        {
                            ID = 2,
                            Content = "Oh, you can’t help that,” said the Cat: “we’re all mad here. I’m mad. You’re mad.” “How do you know I’m mad?” said Alice. “You must be,” said the Cat, or you wouldn’t have come here.",
                            Title = "We're All Mad"
                        },
                        new
                        {
                            ID = 3,
                            Content = "It’s no use going back to yesterday,because I was a different person then.",
                            Title = "Yesterday, Yesterday"
                        },
                        new
                        {
                            ID = 4,
                            Content = "She generally gave herself very good advice (though she very seldom followed it)",
                            Title = "Good advice"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
