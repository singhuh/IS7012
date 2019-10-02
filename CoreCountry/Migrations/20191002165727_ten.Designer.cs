﻿// <auto-generated />
using System;
using CoreCountry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCountry.Migrations
{
    [DbContext(typeof(CoreCountryContext))]
    [Migration("20191002165727_ten")]
    partial class ten
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCountry.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool?>("RequireTravelVisa");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("CoreCountry.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvgTemp");

                    b.Property<decimal>("Budget");

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("CountryID");

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("TravelDate");

                    b.Property<string>("Type")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("CoreCountry.Models.Destination", b =>
                {
                    b.HasOne("CoreCountry.Models.Country", "Country")
                        .WithMany("Destinations")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
