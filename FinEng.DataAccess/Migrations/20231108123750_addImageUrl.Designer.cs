﻿// <auto-generated />
using FinEng.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinEng.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231108123750_addImageUrl")]
    partial class addImageUrl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinEng.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Shoes"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 2,
                            Name = "T-Shirts"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 3,
                            Name = "Pants"
                        },
                        new
                        {
                            CategoryId = 4,
                            DisplayOrder = 4,
                            Name = "Hats"
                        });
                });

            modelBuilder.Entity("FinEng.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Nike Air Max 90 Shoes",
                            ImageUrl = "",
                            Price = "100",
                            Price2 = "90",
                            Title = "Nike Air Max 90"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Nike Air Max 95 Shoes",
                            ImageUrl = "",
                            Price = "120",
                            Price2 = "110",
                            Title = "Nike Air Max 95"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Nike Air Max 97 Shoes",
                            ImageUrl = "",
                            Price = "140",
                            Price2 = "130",
                            Title = "Nike Air Max 97"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            Description = "Nike Air Max 98 Shoes",
                            ImageUrl = "",
                            Price = "160",
                            Price2 = "150",
                            Title = "Nike Air Max 98"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            Description = "Nike Air Max 270 Shoes",
                            ImageUrl = "",
                            Price = "180",
                            Price2 = "170",
                            Title = "Nike Air Max 270"
                        });
                });

            modelBuilder.Entity("FinEng.Models.Product", b =>
                {
                    b.HasOne("FinEng.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
