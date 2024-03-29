﻿// <auto-generated />
using Lecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lecture.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191204183053_TrailMigration")]
    partial class TrailMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lecture.Models.Trail", b =>
                {
                    b.Property<int>("TrailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("length");

                    b.HasKey("TrailId");

                    b.ToTable("Trails");
                });
#pragma warning restore 612, 618
        }
    }
}
