﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(Google_mapsContext))]
    [Migration("20200528082755_InitialDbCreation")]
    partial class InitialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.GoogleMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GoogleMap");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sredja skola",
                            Lat = 43.736938000000002,
                            Long = 15.89859,
                            Rating = 4
                        },
                        new
                        {
                            Id = 2,
                            Address = "Kuca",
                            Lat = 43.750129999999999,
                            Long = 15.8872,
                            Rating = 5
                        },
                        new
                        {
                            Id = 3,
                            Address = "Stan",
                            Lat = 43.751060000000003,
                            Long = 15.88996,
                            Rating = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
