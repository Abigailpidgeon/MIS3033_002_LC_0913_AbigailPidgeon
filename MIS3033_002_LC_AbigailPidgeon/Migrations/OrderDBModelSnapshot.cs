﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using a;

#nullable disable

namespace MIS3033_002_LC_0913_AbigailPidgeon.Migrations
{
    [DbContext(typeof(OrderDB))]
    partial class OrderDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("a.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("QtyApple")
                        .HasColumnType("REAL");

                    b.Property<double>("QtyBanana")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ordersTbl");
                });
#pragma warning restore 612, 618
        }
    }
}
