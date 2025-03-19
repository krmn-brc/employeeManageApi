﻿// <auto-generated />
using System;
using EmployeeManageAp.Web.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManageAp.Web.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("EmployeeManageAp.Web.Entities.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 25, 0, 2, 30, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Development"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 25, 0, 4, 54, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("EmployeeManageAp.Web.Entities.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Etimesgut/Ankara",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "engindemrog@mail.com",
                            FirstName = "Engin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Demiroğ",
                            Phone = "212 435 45 23"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Bahçeşehir/İstanbul",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 13, 0, 3, 6, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "gokhankandemir@mail.com",
                            FirstName = "Gökhan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Kandemir",
                            Phone = "212 334 21 21"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Mecidiyeköy/İstanbul",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 13, 0, 4, 27, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "muratyucedag@mail.com",
                            FirstName = "Murat",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yücedağ",
                            Phone = "212 663 43 87"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Çarşamba/Samsun",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2025, 3, 13, 0, 7, 19, 200, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "zafercomert@mail.com",
                            FirstName = "Zafer",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Cömert",
                            Phone = "212 776 55 42"
                        });
                });

            modelBuilder.Entity("EmployeeManageAp.Web.Entities.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManageAp.Web.Entities.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeManageAp.Web.Entities.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
