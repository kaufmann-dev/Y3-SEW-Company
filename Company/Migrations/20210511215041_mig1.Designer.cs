﻿// <auto-generated />
using System;
using Company.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Company.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20210511215041_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Company.model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("COMPANY_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("COMPANY_NAME");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("COMPANY");
                });

            modelBuilder.Entity("Company.model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EMPLOYEE_ID");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("EMPLOYEE_FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("EMPLOYEE_LAST_NAME");

                    b.Property<int?>("SuperiorId")
                        .HasColumnType("int")
                        .HasColumnName("SUPERIOR_ID");

                    b.HasKey("Id");

                    b.HasIndex("SuperiorId");

                    b.ToTable("EMPLOYEE");
                });

            modelBuilder.Entity("Company.model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("PRODUCT_DESCRIPTION");

                    b.Property<string>("License")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("PRODUCT_LICENSE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("PRODUCT_NAME");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("Company.model.Employee", b =>
                {
                    b.HasOne("Company.model.Employee", "Superior")
                        .WithMany()
                        .HasForeignKey("SuperiorId");

                    b.Navigation("Superior");
                });
#pragma warning restore 612, 618
        }
    }
}
