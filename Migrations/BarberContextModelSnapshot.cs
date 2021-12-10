﻿// <auto-generated />
using System;
using BarberAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BarberAPI.Migrations
{
    [DbContext(typeof(BarberContext))]
    partial class BarberContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("BarberAPI.Models.Appointment", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("clientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("serviceId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BarberAPI.Models.Client", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("fullname")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BarberAPI.Models.Service", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
