﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat_Web_Backend.Models;

namespace Projekat_Web_Backend.Migrations
{
    [DbContext(typeof(CorporationContext))]
    [Migration("20210219170141_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projekat_Web_Backend.Models.Corporation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.HasKey("ID");

                    b.ToTable("Corporation");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Hangar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CorporationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Type");

                    b.HasKey("ID");

                    b.HasIndex("CorporationID");

                    b.ToTable("Hangar");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Salary")
                        .HasColumnType("int")
                        .HasColumnName("Salary");

                    b.Property<int?>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HangarID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Name");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Type");

                    b.HasKey("ID");

                    b.HasIndex("HangarID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Worker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyExpenses")
                        .HasColumnType("int")
                        .HasColumnName("MonthlyExpenses");

                    b.Property<string>("MyHangar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MyHangar");

                    b.Property<string>("MyJob")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MyJob");

                    b.Property<string>("MyVehicle")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MyVehicle");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Type");

                    b.HasKey("ID");

                    b.HasIndex("JobID");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Hangar", b =>
                {
                    b.HasOne("Projekat_Web_Backend.Models.Corporation", "Corporation")
                        .WithMany("Hangari")
                        .HasForeignKey("CorporationID");

                    b.Navigation("Corporation");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Job", b =>
                {
                    b.HasOne("Projekat_Web_Backend.Models.Vehicle", "Vehicle")
                        .WithMany("Jobs")
                        .HasForeignKey("VehicleID");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Vehicle", b =>
                {
                    b.HasOne("Projekat_Web_Backend.Models.Hangar", "Hangar")
                        .WithMany("Vehicles")
                        .HasForeignKey("HangarID");

                    b.Navigation("Hangar");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Worker", b =>
                {
                    b.HasOne("Projekat_Web_Backend.Models.Job", "Job")
                        .WithMany("Workers")
                        .HasForeignKey("JobID");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Corporation", b =>
                {
                    b.Navigation("Hangari");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Hangar", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Job", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("Projekat_Web_Backend.Models.Vehicle", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
