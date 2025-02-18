﻿// <auto-generated />
using System;
using BuyMe.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuyMe.Persistence.Migrations
{
    [DbContext(typeof(BuyMeDbContext))]
    [Migration("20211013065936_AddItemCart")]
    partial class AddItemCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuyMe.Domain.Entities.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QTN")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Category", b =>
                {
                    b.Property<int?>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CategoryDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CategoryDescriptions");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Business")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrencyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CustomerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.NumberSequence", b =>
                {
                    b.Property<int>("NumberSequenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("LastNumber")
                        .HasColumnType("int");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberSequenceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumberSequenceId");

                    b.HasIndex("CompanyId");

                    b.ToTable("NumberSequences");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowMarketing")
                        .HasColumnType("bit");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<decimal?>("DefaultBuyingPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("DefaultSellingPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitOfMeasureId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UnitOfMeasureId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.ProductDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryDescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryDescriptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescriptions");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesOrder", b =>
                {
                    b.Property<long>("SalesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("Freight")
                        .HasColumnType("float");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesOrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesTypeId")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("SalesOrderId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalesTypeId");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesOrderLine", b =>
                {
                    b.Property<int>("SalesOrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<long>("SalesOrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double>("TaxAmount")
                        .HasColumnType("float");

                    b.Property<double>("TaxPercentage")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("SalesOrderLineId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderLines");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("SalesTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("SalesTypes");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.TemplateImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplateImages");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.UnitOfMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UOM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("UnitOfMeasures");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Branch", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", null)
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyMe.Domain.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("BuyMe.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Category", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CategoryDescription", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Category", "Category")
                        .WithMany("CategoryDescriptions")
                        .HasForeignKey("CategoryId");

                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Company", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Currency", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", null)
                        .WithMany("Currencies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Customer", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyMe.Domain.Entities.CustomerType", "CustomerType")
                        .WithMany()
                        .HasForeignKey("CustomerTypeId");

                    b.Navigation("Company");

                    b.Navigation("CustomerType");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.CustomerType", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Employee", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.NumberSequence", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Product", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("BuyMe.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyMe.Domain.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("BuyMe.Domain.Entities.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany()
                        .HasForeignKey("UnitOfMeasureId");

                    b.Navigation("Branch");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("Currency");

                    b.Navigation("UnitOfMeasure");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.ProductDescription", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.CategoryDescription", "CategoryDescription")
                        .WithMany()
                        .HasForeignKey("CategoryDescriptionId");

                    b.HasOne("BuyMe.Domain.Entities.Product", "Product")
                        .WithMany("ProductDescriptions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryDescription");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.ProductImages", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesOrder", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyMe.Domain.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("BuyMe.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("BuyMe.Domain.Entities.SalesType", "SalesType")
                        .WithMany()
                        .HasForeignKey("SalesTypeId");

                    b.Navigation("Branch");

                    b.Navigation("Company");

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("SalesType");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesOrderLine", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("BuyMe.Domain.Entities.SalesOrder", "SalesOrder")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SalesOrder");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesType", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.TemplateImages", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Template", "Template")
                        .WithMany("Images")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.UnitOfMeasure", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Warehouse", b =>
                {
                    b.HasOne("BuyMe.Domain.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("BuyMe.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Category", b =>
                {
                    b.Navigation("CategoryDescriptions");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Company", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Currencies");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductDescriptions");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.SalesOrder", b =>
                {
                    b.Navigation("SalesOrderLines");
                });

            modelBuilder.Entity("BuyMe.Domain.Entities.Template", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
