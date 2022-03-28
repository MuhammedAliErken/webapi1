﻿// <auto-generated />
using Cars.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cars.DataAccess.Migrations
{
    [DbContext(typeof(CarsDbContext))]
    partial class CarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cars.Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Cars.Entities.Boat", b =>
                {
                    b.HasBaseType("Cars.Entities.Vehicle");

                    b.Property<int>("BoatId")
                        .HasColumnType("int");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("Cars.Entities.Bus", b =>
                {
                    b.HasBaseType("Cars.Entities.Vehicle");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("Cars.Entities.Car", b =>
                {
                    b.HasBaseType("Cars.Entities.Vehicle");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("IHHeadlights")
                        .HasColumnType("bit");

                    b.Property<bool>("IHWheels")
                        .HasColumnType("bit");

                    b.Property<bool>("IHeadlightsOn")
                        .HasColumnType("bit");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Cars.Entities.Boat", b =>
                {
                    b.HasOne("Cars.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("Cars.Entities.Boat", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cars.Entities.Bus", b =>
                {
                    b.HasOne("Cars.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("Cars.Entities.Bus", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cars.Entities.Car", b =>
                {
                    b.HasOne("Cars.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("Cars.Entities.Car", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
