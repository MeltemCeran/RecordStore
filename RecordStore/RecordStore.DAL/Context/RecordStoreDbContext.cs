using Azure;
using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace RecordStore.DAL.Context
{
    public class RecordStoreDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string[] server = { "DESKTOP-QJIAQ3L", "LAPTOP-3HH2461E", "DESKTOP-M590E2O\\SAMETLESSON", "DILA\\AYDANPERSONALSVR" };
            string connectionString = $"Data Source={server[0]};Database=RecordStoreDb;Trusted_Connection=True;Encrypt=No";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "dbo");
                entity.Property(e => e.UserName).HasColumnType("varchar(40)");

            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("Album", "dbo");
                entity.Property(e => e.Name).HasColumnType("nvarchar(50)");
                entity.Property(e => e.Singers).HasColumnType("nvarchar(50)");
                entity.Property(e => e.Price).HasColumnType("decimal(7,2)");
                entity.Property(e => e.Discount).HasColumnType("decimal(7,2)");
            });

            modelBuilder.Entity<User>().HasData(
                //ABCabc+*
                new User { Id = 1, UserName = "Samet", Password = "1c878f9f7033734c34647bfd6bb1e312dd835f319b3df608873444f3a9e65769" },
                //qweCC:!12
                new User { Id = 2, UserName = "Meltem", Password = "45e01a38ba96519d7ad13fbf9cb03442768c9f3f2d4c69143554670e54d3f18b" },
                //qazWSX:5!
                new User { Id = 3, UserName = "Batuhan", Password = "428b5b31f6f928e466cba5926691b5b18b9dea5d8243114d27cb2909464f22d7" },
                //PRoje44+:!
                new User { Id = 4, UserName = "Aydan", Password = "504d3d0e64bef294ad0e15b86f8813bc6ea3b20cd70787b98d47aadba7d98d0d" }
            );

            modelBuilder.Entity<Album>().HasData(
                
                new Album
                {
                    Id = 1,
                    Name = "AM",
                    Singers = "Arctic Monkeys",
                    PublishedDate = new DateOnly(2013, 08, 12),
                    CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 100,
                    Discount = 0.78,
                    IsActive = true
                },
                
                new Album
                {
                    Id = 2,
                    Name = "Favourite Worst Nightmare",
                    Singers = "Arctic Monkeys",
                    PublishedDate = new DateOnly(2007, 10, 03),
                    CreatedDate = new DateTime(2024, 9, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 200,
                    Discount = 0.5,
                    IsActive = true
                },
                
                new Album
                {
                    Id = 3,
                    Name = "Biraz Pop Biraz Sezen",
                    Singers = "Sezen Aksu",
                    PublishedDate = new DateOnly(2017, 02, 17),
                    CreatedDate = new DateTime(2024, 8, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 300,
                    Discount = 0.76,
                    IsActive = true
                },
                
                new Album
                {
                    Id = 4,
                    Name = "Please Please Me",
                    Singers = "The Beatles",
                    PublishedDate = new DateOnly(1963, 07, 11),
                    CreatedDate = new DateTime(2024, 7, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 750,
                    Discount = 0.76,
                    IsActive = false
                },
                
                new Album
                {
                    Id = 5,
                    Name = "CryBaby",
                    Singers = "Lil Peep",
                    PublishedDate = new DateOnly(2016, 06, 18),
                    CreatedDate = new DateTime(2024, 6, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 500,
                    Discount = 1.0,
                    IsActive = true
                },
                
                new Album
                {
                    Id = 6,
                    Name = "Astroworld",
                    Singers = "Travis Scott",
                    PublishedDate = new DateOnly(2023, 05, 21),
                    CreatedDate = new DateTime(2024, 5, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 625,
                    Discount = 0.89,
                    IsActive = true
                },

                 new Album
                 {
                     Id = 7,
                     Name = "Bak Kollarım Burada",
                     Singers = "Mert Demir",
                     PublishedDate = new DateOnly(2019, 04, 05),
                     CreatedDate = new DateTime(2024, 4, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 310,
                     Discount = 0.78,
                     IsActive = false
                 },
                
                 new Album
                 {
                     Id = 8,
                     Name = "Homecoming",
                     Singers = "Beyonce",
                     PublishedDate = new DateOnly(2019, 09, 07),
                     CreatedDate = new DateTime(2024, 3, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 900,
                     Discount = 0.93,
                     IsActive = true
                 },
                 
                 new Album
                 {
                     Id = 9,
                     Name = "Yolcu",
                     Singers = "Neşet Ertaş",
                     PublishedDate = new DateOnly(2003, 05, 13),
                     CreatedDate = new DateTime(2024, 2, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 95,
                     Discount = 0.95,
                     IsActive = false
                 },
                 
                 new Album
                 {
                     Id = 10,
                     Name = "Seni Kendime Sakladım",
                     Singers = "Duman",
                     PublishedDate = new DateOnly(2004, 05, 19),
                     CreatedDate = new DateTime(2024, 1, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 175,
                     Discount = 0.85,
                     IsActive = true
                 },
                                  
                 new Album
                 {
                     Id = 11,
                     Name = "Antichrist Superstar",
                     Singers = "Marilyn Manson",
                     PublishedDate = new DateOnly(1996, 10, 08),
                     CreatedDate = new DateTime(2024, 6, 10, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 700,
                     Discount = 0.70,
                     IsActive = true
                 },

                 new Album
                 {
                     Id = 12,
                     Name = "Hal Hal",
                     Singers = "Barış Manço",
                     PublishedDate = new DateOnly(1989, 11, 22),
                     CreatedDate = new DateTime(2024, 6, 9, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 585,
                     Discount = 0.65,
                     IsActive = true
                 },
                 
                  new Album
                  {
                      Id = 13,
                      Name = "In Utero",
                      Singers = "Nirvana",
                      PublishedDate = new DateOnly(1993, 09, 21),
                      CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                      Price = 100,
                      Discount = 1.0,
                      IsActive = false
                  },
                  
                  new Album
                  {
                      Id = 14,
                      Name = "Büyük İnsan",
                      Singers = "Gökhan Türkmen",
                      PublishedDate = new DateOnly(2010, 07, 16),
                      CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                      Price = 320,
                      Discount = 0.65,
                      IsActive = true
                  },

                  new Album
                  {
                      Id = 15,
                      Name = "Resimdeki Gözyaşları",
                      Singers = "Cem Karaca",
                      PublishedDate = new DateOnly(1968, 08, 10),
                      CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                      Price = 700,
                      Discount = 0.93,
                      IsActive = false
                  },

                  new Album
                  {
                      Id = 16,
                      Name = "Dünden Yarına",
                      Singers = "İlhan İrem'",
                      PublishedDate = new DateOnly(1988, 03, 17),
                      CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                      Price = 560,
                      Discount = 0.84,
                      IsActive = true
                  }
            );

        }

    }


}
