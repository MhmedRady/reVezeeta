﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vezeeta.DBL;

#nullable disable

namespace vezeeta.DBL.Migrations
{
    [DbContext(typeof(VezeetaDB))]
    [Migration("20230119142952_add_department_slug")]
    partial class adddepartmentslug
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("vezeeta.DBL.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2")
                        .HasComment("Created At DateTime");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("slug_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2")
                        .HasComment("Last Update DateTime");

                    b.HasKey("Id");

                    b.HasIndex("name_ar")
                        .IsUnique();

                    b.HasIndex("name_en")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("vezeeta.DBL.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("N_ID")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Doctor User National ID");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2")
                        .HasComment("Created At DateTime");

                    b.Property<DateTime?>("dob")
                        .HasColumnType("datetime2")
                        .HasComment("User Date Of Barth");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("is_admin")
                        .HasColumnType("bit");

                    b.Property<bool>("is_doctor")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profile_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2")
                        .HasComment("Last Update DateTime");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("email")
                        .IsUnique()
                        .HasFilter("[email] IS NOT NULL");

                    b.HasIndex("username")
                        .IsUnique()
                        .HasFilter("[username] IS NOT NULL");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}