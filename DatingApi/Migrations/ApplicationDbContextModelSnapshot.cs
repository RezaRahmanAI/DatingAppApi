﻿// <auto-generated />
using DatingApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatingApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatingApi.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main Street",
                            Email = "johndoe@example.com",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm Street",
                            Email = "janesmith@example.com",
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak Avenue",
                            Email = "alicej@example.com",
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine Lane",
                            Email = "bobb@example.com",
                            Name = "Bob Brown"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
