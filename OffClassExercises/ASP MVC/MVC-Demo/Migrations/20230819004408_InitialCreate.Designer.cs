﻿// <auto-generated />
using MVC_Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Demo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230819004408_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("MVC_Demo.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IsJobAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobExpiredDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobPostedDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobRequirements")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
