﻿// <auto-generated />
using System;
using CarTax.Taxfreecar.Infrastruchar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarTax.Taxfreecar.Infrastruchar.Migrations
{
    [DbContext(typeof(TaxfreecarDBContext))]
    partial class TaxfreecarDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarTax.AggregateRoot.TaxFreeCar", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("TaxfreecarId");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TypeCarId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("TaxfreecarId");

                    b.ToTable("Taxfreecar", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}