﻿// <auto-generated />
using System;
using Delegation.Models.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Delegation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Delegation.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Delegation.Models.BusinessTrip", b =>
                {
                    b.Property<int>("BusinessTripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinationID")
                        .HasColumnType("int");

                    b.Property<int?>("DriverEmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("FinalMeter")
                        .HasColumnType("int");

                    b.Property<int>("InitialMeter")
                        .HasColumnType("int");

                    b.Property<int?>("KeeperEmployeeID")
                        .HasColumnType("int");

                    b.Property<int?>("KilometersCardID")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("BusinessTripID");

                    b.HasIndex("CarID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("DriverEmployeeID");

                    b.HasIndex("KeeperEmployeeID");

                    b.HasIndex("KilometersCardID");

                    b.HasIndex("ProjectID");

                    b.ToTable("BusinessTrips");
                });

            modelBuilder.Entity("Delegation.Models.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MainDriverEmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("MeterStatus")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarID");

                    b.HasIndex("MainDriverEmployeeID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Delegation.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.HasIndex("AddressID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Delegation.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationID");

                    b.HasIndex("AddressID");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Delegation.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("Delegation.Models.KilometersCard", b =>
                {
                    b.Property<int>("KilometersCardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("CardSymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KilometersCardID");

                    b.HasIndex("CarID");

                    b.ToTable("KilometersCard");
                });

            modelBuilder.Entity("Delegation.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Delegation.Models.Driver", b =>
                {
                    b.HasBaseType("Delegation.Models.Employee");

                    b.Property<int>("DriverID")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Driver");
                });

            modelBuilder.Entity("Delegation.Models.BusinessTrip", b =>
                {
                    b.HasOne("Delegation.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID");

                    b.HasOne("Delegation.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID");

                    b.HasOne("Delegation.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverEmployeeID");

                    b.HasOne("Delegation.Models.Employee", "Keeper")
                        .WithMany()
                        .HasForeignKey("KeeperEmployeeID");

                    b.HasOne("Delegation.Models.KilometersCard", "KilometersCard")
                        .WithMany()
                        .HasForeignKey("KilometersCardID");

                    b.HasOne("Delegation.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID");

                    b.Navigation("Car");

                    b.Navigation("Destination");

                    b.Navigation("Driver");

                    b.Navigation("Keeper");

                    b.Navigation("KilometersCard");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Delegation.Models.Car", b =>
                {
                    b.HasOne("Delegation.Models.Driver", "MainDriver")
                        .WithMany("UsedCars")
                        .HasForeignKey("MainDriverEmployeeID");

                    b.Navigation("MainDriver");
                });

            modelBuilder.Entity("Delegation.Models.Company", b =>
                {
                    b.HasOne("Delegation.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Delegation.Models.Destination", b =>
                {
                    b.HasOne("Delegation.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Delegation.Models.KilometersCard", b =>
                {
                    b.HasOne("Delegation.Models.Car", null)
                        .WithMany("KilometersCards")
                        .HasForeignKey("CarID");
                });

            modelBuilder.Entity("Delegation.Models.Project", b =>
                {
                    b.HasOne("Delegation.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Delegation.Models.Car", b =>
                {
                    b.Navigation("KilometersCards");
                });

            modelBuilder.Entity("Delegation.Models.Driver", b =>
                {
                    b.Navigation("UsedCars");
                });
#pragma warning restore 612, 618
        }
    }
}
