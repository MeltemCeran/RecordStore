﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordStore.DAL.Context;

#nullable disable

namespace RecordStore.DAL.Migrations
{
    [DbContext(typeof(RecordStoreDbContext))]
    [Migration("20241026152417_SeedDataCreated")]
    partial class SeedDataCreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecordStore.DAL.Entities.Concrete.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(7,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.Property<DateOnly>("PublishedDate")
                        .HasColumnType("date");

                    b.Property<string>("Singers")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Album", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Sametten Nameler",
                            Price = 100m,
                            PublishedDate = new DateOnly(2024, 10, 26),
                            Singers = "Samet"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            Discount = 0.5m,
                            IsActive = true,
                            Name = "Batuhandan Nameler",
                            Price = 200m,
                            PublishedDate = new DateOnly(2024, 10, 25),
                            Singers = "Batuhan"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 8, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Meltemden Nameler",
                            Price = 300m,
                            PublishedDate = new DateOnly(2024, 10, 24),
                            Singers = "Meltem"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 7, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Aydandan Nameler",
                            Price = 400m,
                            PublishedDate = new DateOnly(2024, 10, 23),
                            Singers = "Aydan"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 5, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 4, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 3, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 2, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 6, 10, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 6, 9, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286),
                            IsActive = true,
                            Name = "Ankaranın Ayazı",
                            Price = 500m,
                            PublishedDate = new DateOnly(2024, 11, 22),
                            Singers = "Ankaranın Bağları"
                        });
                });

            modelBuilder.Entity("RecordStore.DAL.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("User", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            Password = "7908281b119b087a0c719cd42d7d75a9f301304f4db96b03756001317dbd942f",
                            UserName = "Samet"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            Password = "982357496c6e531cba092c30369173cf0277e81553aa215c0c4c06529d05ea30",
                            UserName = "Meltem"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            Password = "dd130a849d7b29e5541b05d2f7f86a4acd4f1ec598c1c9438783f56bc4f0ff80",
                            UserName = "Batuhan"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            Password = "f3c6b429c665c140db8fe878b5bef89ae9e1be09bd87ecd537706b8db3ef7e62",
                            UserName = "Aydan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
