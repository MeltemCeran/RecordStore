using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Context
{
    public class RecordStoreDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string[] server = { "DESKTOP-QJIAQ3L", "LAPTOP-3HH2461E", "DESKTOP-M590E2O\\SAMETLESSON" };
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

                new User { Id = 1, UserName = "Samet", Password = "7908281b119b087a0c719cd42d7d75a9f301304f4db96b03756001317dbd942f" }, //123a

                new User { Id = 2, UserName = "Meltem", Password = "982357496c6e531cba092c30369173cf0277e81553aa215c0c4c06529d05ea30" }, //123ab

                new User { Id = 3, UserName = "Batuhan", Password = "dd130a849d7b29e5541b05d2f7f86a4acd4f1ec598c1c9438783f56bc4f0ff80" }, //123abc

                new User { Id = 4, UserName = "Aydan", Password = "f3c6b429c665c140db8fe878b5bef89ae9e1be09bd87ecd537706b8db3ef7e62" } //123abcd

            );



            modelBuilder.Entity<Album>().HasData(

                new Album
                {
                    Id = 1,

                    Name = "Sametten Nameler",

                    Singers = "Samet",

                    PublishedDate = new DateOnly(2024, 10, 26),
                    CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 100,

                    IsActive = true

                },

                new Album
                {
                    Id = 2,

                    Name = "Batuhandan Nameler",

                    Singers = "Batuhan",

                    PublishedDate = new DateOnly(2024, 10, 25),
                    CreatedDate = new DateTime(2024, 9, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 200,

                    Discount = 0.5,

                    IsActive = true

                },

                new Album
                {
                    Id = 3,

                    Name = "Meltemden Nameler",

                    Singers = "Meltem",

                    PublishedDate = new DateOnly(2024, 10, 24),
                    CreatedDate = new DateTime(2024, 8, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 300,



                    IsActive = true

                },

                new Album
                {
                    Id = 4,

                    Name = "Aydandan Nameler",

                    Singers = "Aydan",

                    PublishedDate = new DateOnly(2024, 10, 23),
                    CreatedDate = new DateTime(2024, 7, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 400,



                    IsActive = true

                },

                new Album
                {
                    Id = 5,
                    Name = "Ankaranın Ayazı",
                    Singers = "Ankaranın Bağları",
                    PublishedDate = new DateOnly(2024, 11, 22),
                    CreatedDate = new DateTime(2024, 6, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                    Price = 500,
                    IsActive = true
                },

                new Album
                  {
                     Id = 6,
                     Name = "Ankaranın Ayazı",
                     Singers = "Ankaranın Bağları",
                     PublishedDate = new DateOnly(2024, 11, 22),
                     CreatedDate = new DateTime(2024, 5, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                     Price = 500,
                     IsActive = true
                  },
                 new Album
                     {
                         Id = 7,
                         Name = "Ankaranın Ayazı",
                         Singers = "Ankaranın Bağları",
                         PublishedDate = new DateOnly(2024, 11, 22),
                         CreatedDate = new DateTime(2024, 4, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                         Price = 500,
                         IsActive = true
                     },
                        new Album
                        {
                            Id = 8,
                            Name = "Ankaranın Ayazı",
                            Singers = "Ankaranın Bağları",
                            PublishedDate = new DateOnly(2024, 11, 22),
                            CreatedDate = new DateTime(2024, 3, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            Price = 500,
                            IsActive = true
                        },
                           new Album
                           {
                               Id = 9,
                               Name = "Ankaranın Ayazı",
                               Singers = "Ankaranın Bağları",
                               PublishedDate = new DateOnly(2024, 11, 22),
                               CreatedDate = new DateTime(2024, 2, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                               Price = 500,
                               IsActive = true
                           },
                              new Album
                              {
                                  Id = 10,
                                  Name = "Ankaranın Ayazı",
                                  Singers = "Ankaranın Bağları",
                                  PublishedDate = new DateOnly(2024, 11, 22),
                                  CreatedDate = new DateTime(2024, 1, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                                  Price = 500,
                                  IsActive = true
                              },
                                 new Album
                                 {
                                     Id = 11,
                                     Name = "Ankaranın Ayazı",
                                     Singers = "Ankaranın Bağları",
                                     PublishedDate = new DateOnly(2024, 11, 22),
                                     CreatedDate = new DateTime(2024, 6, 10, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                                     Price = 500,
                                     IsActive = true
                                 },
                                    new Album
                                    {
                                        Id = 12,
                                        Name = "Ankaranın Ayazı",
                                        Singers = "Ankaranın Bağları",
                                        PublishedDate = new DateOnly(2024, 11, 22),
                                        CreatedDate = new DateTime(2024, 6, 9, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                                        Price = 500,
                                        IsActive = true
                                    }
                                      


            );

        }

    }


}
