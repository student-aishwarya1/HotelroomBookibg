﻿// <auto-generated />
using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HotelBooking.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20240120065742_abhijit")]
    partial class abhijit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HotelBooking.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CheckIn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CheckOut")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Hotel_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("HotelBooking.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("C_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Contact")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("checkInDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("checkInTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("checkOutDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("checkOutTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("person")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("roomType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HotelBooking.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("HotelBooking.Models.HotelDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bed_Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Hotel_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("HotelDetail");
                });

            modelBuilder.Entity("HotelBooking.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Passward")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("HotelBooking.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ConfirmPassword")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Password")
                        .HasColumnType("integer");

                    b.Property<int>("Pincode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("HotelBooking.Models.HotelDetails", b =>
                {
                    b.HasOne("HotelBooking.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
