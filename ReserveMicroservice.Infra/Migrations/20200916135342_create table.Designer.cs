﻿// <auto-generated />
using System;
using ReserveMicroservice.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ReserveMicroservice.Infra.Migrations
{
    [DbContext(typeof(ReserveContext))]
    [Migration("20200916135342_create table")]
    partial class createtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.MoneyValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MoneyValues");
                });

            modelBuilder.Entity("ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.Reserve", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DevolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MoneyValueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MoneyValueId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.Reserve", b =>
                {
                    b.HasOne("ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate.MoneyValue", "MoneyValue")
                        .WithMany()
                        .HasForeignKey("MoneyValueId");
                });
#pragma warning restore 612, 618
        }
    }
}