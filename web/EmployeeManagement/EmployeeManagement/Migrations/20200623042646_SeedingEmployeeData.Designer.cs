﻿// <auto-generated />
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200623042646_SeedingEmployeeData")]
    partial class SeedingEmployeeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ava");

                    b.Property<int>("departerment");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ava = "~/images/unknownPerson.jpg",
                            departerment = 0,
                            email = "nguyendangquanghbt12b7@gmail.com",
                            fullName = "Nguyễn Đăng Quang"
                        },
                        new
                        {
                            Id = 2,
                            ava = "~/images/unknownPerson.jpg",
                            departerment = 2,
                            email = "minhminh.codegym@gmail.com",
                            fullName = "Tôn Thất Anh Minh"
                        },
                        new
                        {
                            Id = 3,
                            ava = "~/images/unknownPerson.jpg",
                            departerment = 0,
                            email = "xuantrung.nguyen@gmail.com",
                            fullName = "Nguyễn Xuân Trung"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}