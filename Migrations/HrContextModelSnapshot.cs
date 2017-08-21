﻿// <auto-generated />
using HordeFlow.HR.Infrastructure;
using HordeFlow.HR.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HordeFlow.HR.Migrations
{
    [DbContext(typeof(HrContext))]
    partial class HrContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(300);

                    b.Property<string>("AddressType")
                        .HasMaxLength(15);

                    b.Property<string>("City");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("StateId")
                        .IsRequired();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ParentCompanyId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("ParentCompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.CompanyAddress", b =>
                {
                    b.Property<int>("CompanyId");

                    b.Property<int>("AddressId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("CompanyId", "AddressId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("CompanyAddresses");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId", "Name")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId", "Name")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Avatar")
                        .HasMaxLength(300);

                    b.Property<DateTime?>("Birthdate");

                    b.Property<string>("Citizenship")
                        .HasMaxLength(100);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<int?>("DesignationId");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("GSIS")
                        .HasMaxLength(50);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("MaritalStatus");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("PHIC")
                        .HasMaxLength(50);

                    b.Property<string>("Religion")
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SSS")
                        .HasMaxLength(50);

                    b.Property<string>("TIN")
                        .HasMaxLength(50);

                    b.Property<int?>("TeamId");

                    b.Property<string>("Title");

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("TeamId");

                    b.HasIndex("CompanyId", "Code");

                    b.HasIndex("CompanyId", "Id");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.EmployeeAddress", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("AddressId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("EmployeeId", "AddressId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("EmployeeAddresses");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId", "Name")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<string>("MobileNo");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RecoveryEmail");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("UserCreatedId");

                    b.Property<int?>("UserModifiedId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Address", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.State", "State")
                        .WithMany("Addresses")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Company", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "ParentCompany")
                        .WithMany("Companies")
                        .HasForeignKey("ParentCompanyId");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.CompanyAddress", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Address", "Address")
                        .WithMany("CompanyAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany("CompanyAddresses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Department", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Designation", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany("Designations")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Employee", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Designation", "Designation")
                        .WithMany("Employees")
                        .HasForeignKey("DesignationId");

                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.EmployeeAddress", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Address", "Address")
                        .WithMany("EmployeeAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Employee", "Employee")
                        .WithMany("EmployeeAddresses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.State", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.Team", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany("Teams")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("HordeFlow.HR.Infrastructure.Models.User", b =>
                {
                    b.HasOne("HordeFlow.HR.Infrastructure.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
