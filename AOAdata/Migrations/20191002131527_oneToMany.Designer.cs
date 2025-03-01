﻿// <auto-generated />
using System;
using AOAdata.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AOAdata.Migrations
{
    [DbContext(typeof(AOAContext))]
    [Migration("20191002131527_oneToMany")]
    partial class oneToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AOAdata.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PartNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("AOAdata.Models.PartsInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CostCode");

                    b.Property<int?>("PartId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.ToTable("PartsInventory");
                });

            modelBuilder.Entity("AOAdata.Models.PartsInventory", b =>
                {
                    b.HasOne("AOAdata.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");
                });
#pragma warning restore 612, 618
        }
    }
}
