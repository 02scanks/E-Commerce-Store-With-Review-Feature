﻿// <auto-generated />
using System;
using EComm_Review_App.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EComm_Review_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240727063246_added_product_image")]
    partial class added_product_image
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<float>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("ProductImageData")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.ToTable("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
