﻿// <auto-generated />
using System;
using MahaleSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MahaleSystem.Migrations
{
    [DbContext(typeof(ManahelContext))]
    [Migration("20210416190339_changeinAccount")]
    partial class changeinAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MahaleSystem.Models.ImagesManahel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagesString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManahelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManahelId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MahaleSystem.Models.Khalias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KhaliaLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhaliaType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManhalId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PraweezCount")
                        .HasColumnType("int");

                    b.Property<int>("Ssn")
                        .HasColumnType("int");

                    b.Property<string>("Wood")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManhalId");

                    b.ToTable("khaliases");
                });

            modelBuilder.Entity("MahaleSystem.Models.Manahel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("manahels");
                });

            modelBuilder.Entity("MahaleSystem.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatePick")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManhalId")
                        .HasColumnType("int");

                    b.Property<string>("ProductAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManhalId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MahaleSystem.Models.Queue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateFertilization")
                        .HasColumnType("datetime2");

                    b.Property<int>("KhaliaId")
                        .HasColumnType("int");

                    b.Property<string>("QueueStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KhaliaId")
                        .IsUnique();

                    b.ToTable("Queues");
                });

            modelBuilder.Entity("MahaleSystem.Models.ImagesManahel", b =>
                {
                    b.HasOne("MahaleSystem.Models.Manahel", "Manahel")
                        .WithMany("ImageManhals")
                        .HasForeignKey("ManahelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manahel");
                });

            modelBuilder.Entity("MahaleSystem.Models.Khalias", b =>
                {
                    b.HasOne("MahaleSystem.Models.Manahel", "Manhal")
                        .WithMany("Khaliases")
                        .HasForeignKey("ManhalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manhal");
                });

            modelBuilder.Entity("MahaleSystem.Models.Product", b =>
                {
                    b.HasOne("MahaleSystem.Models.Manahel", "Manhal")
                        .WithMany("Products")
                        .HasForeignKey("ManhalId");

                    b.Navigation("Manhal");
                });

            modelBuilder.Entity("MahaleSystem.Models.Queue", b =>
                {
                    b.HasOne("MahaleSystem.Models.Khalias", "Khalia")
                        .WithOne("Queues")
                        .HasForeignKey("MahaleSystem.Models.Queue", "KhaliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khalia");
                });

            modelBuilder.Entity("MahaleSystem.Models.Khalias", b =>
                {
                    b.Navigation("Queues");
                });

            modelBuilder.Entity("MahaleSystem.Models.Manahel", b =>
                {
                    b.Navigation("ImageManhals");

                    b.Navigation("Khaliases");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
