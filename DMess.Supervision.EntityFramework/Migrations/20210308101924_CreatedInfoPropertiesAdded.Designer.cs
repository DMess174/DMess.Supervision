﻿// <auto-generated />
using System;
using DMess.Supervision.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DMess.Supervision.EntityFramework.Migrations
{
    [DbContext(typeof(CommonDataContext))]
    [Migration("20210308101924_CreatedInfoPropertiesAdded")]
    partial class CreatedInfoPropertiesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Contracts.Contract", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsInForce")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Customers.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PostId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Factories.Factory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubdivisionDepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubdivisionDepartmentId");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.PID", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Consignee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FactoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ShipmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecificationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("PIDs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PID");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.Specification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Facility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Programme")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Products.ProductType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Subdivision", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subdivisions");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.SubdivisionDepartment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubdivisionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("SubdivisionDepartments");
                });

            modelBuilder.Entity("EmployeeFactory", b =>
                {
                    b.Property<string>("EmployeesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FactoriesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeesId", "FactoriesId");

                    b.HasIndex("FactoriesId");

                    b.ToTable("EmployeeFactory");
                });

            modelBuilder.Entity("FactoryProductType", b =>
                {
                    b.Property<string>("FactoriesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductTypesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FactoriesId", "ProductTypesId");

                    b.HasIndex("ProductTypesId");

                    b.ToTable("FactoryProductType");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.ValvePID", b =>
                {
                    b.HasBaseType("DMess.Supervision.CommonModel.Models.Orders.PID");

                    b.Property<byte>("ClimaticModification")
                        .HasColumnType("tinyint");

                    b.Property<byte>("ConnectionType")
                        .HasColumnType("tinyint");

                    b.Property<int>("Diameter")
                        .HasColumnType("int");

                    b.Property<byte>("DriveType")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PressureDifference")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PressureLimit")
                        .HasColumnType("tinyint");

                    b.Property<byte>("SeismicStability")
                        .HasColumnType("tinyint");

                    b.HasDiscriminator().HasValue("ValvePID");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Account", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("DMess.Supervision.CommonModel.Models.Account", "EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Contracts.Contract", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Customers.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Employee", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.SubdivisionDepartment", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("DMess.Supervision.CommonModel.Models.Post", "Post")
                        .WithMany("Employees")
                        .HasForeignKey("PostId");

                    b.Navigation("Department");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Factories.Factory", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.SubdivisionDepartment", "SubdivisionDepartment")
                        .WithMany("Factories")
                        .HasForeignKey("SubdivisionDepartmentId");

                    b.Navigation("SubdivisionDepartment");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.PID", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Factories.Factory", "Factory")
                        .WithMany("PIDs")
                        .HasForeignKey("FactoryId");

                    b.HasOne("DMess.Supervision.CommonModel.Models.Products.ProductType", "ProductType")
                        .WithMany("PIDs")
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("DMess.Supervision.CommonModel.Models.Orders.Specification", "Specification")
                        .WithMany("PIDs")
                        .HasForeignKey("SpecificationId");

                    b.Navigation("Factory");

                    b.Navigation("ProductType");

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.Specification", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Customers.Customer", "Customer")
                        .WithMany("Specifications")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.SubdivisionDepartment", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Department", "Department")
                        .WithMany("Subdivisions")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("DMess.Supervision.CommonModel.Models.Subdivision", "Subdivision")
                        .WithMany("Departments")
                        .HasForeignKey("SubdivisionId");

                    b.Navigation("Department");

                    b.Navigation("Subdivision");
                });

            modelBuilder.Entity("EmployeeFactory", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMess.Supervision.CommonModel.Models.Factories.Factory", null)
                        .WithMany()
                        .HasForeignKey("FactoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FactoryProductType", b =>
                {
                    b.HasOne("DMess.Supervision.CommonModel.Models.Factories.Factory", null)
                        .WithMany()
                        .HasForeignKey("FactoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMess.Supervision.CommonModel.Models.Products.ProductType", null)
                        .WithMany()
                        .HasForeignKey("ProductTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Customers.Customer", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Department", b =>
                {
                    b.Navigation("Subdivisions");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Employee", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Factories.Factory", b =>
                {
                    b.Navigation("PIDs");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Orders.Specification", b =>
                {
                    b.Navigation("PIDs");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Post", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Products.ProductType", b =>
                {
                    b.Navigation("PIDs");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.Subdivision", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("DMess.Supervision.CommonModel.Models.SubdivisionDepartment", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Factories");
                });
#pragma warning restore 612, 618
        }
    }
}
