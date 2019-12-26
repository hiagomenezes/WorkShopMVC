﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkShopMVC.Models;

namespace WorkShopMVC.Migrations
{
    [DbContext(typeof(WorkShopMVCContext))]
    partial class WorkShopMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkShopMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WorkShopMVC.Models.SelesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Status");

                    b.Property<int?>("sellerId");

                    b.HasKey("Id");

                    b.HasIndex("sellerId");

                    b.ToTable("SelesRecord");
                });

            modelBuilder.Entity("WorkShopMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("departmentId");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WorkShopMVC.Models.SelesRecord", b =>
                {
                    b.HasOne("WorkShopMVC.Models.Seller", "seller")
                        .WithMany("seles")
                        .HasForeignKey("sellerId");
                });

            modelBuilder.Entity("WorkShopMVC.Models.Seller", b =>
                {
                    b.HasOne("WorkShopMVC.Models.Department", "department")
                        .WithMany("sellers")
                        .HasForeignKey("departmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
