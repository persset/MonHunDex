﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonHunDex.Data;

#nullable disable

namespace MonHunDex.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221227140600_CreateAilmentTable")]
    partial class CreateAilmentTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MonHunDex.Models.Ailment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ailments");
                });

            modelBuilder.Entity("MonHunDex.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("MonHunDex.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationTypeId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MonHunDex.Models.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocationTypes");
                });

            modelBuilder.Entity("MonHunDex.Models.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Behavior")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Physiology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuperHeroes");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterElement", b =>
                {
                    b.Property<int>("ElementId")
                        .HasColumnType("int");

                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.HasKey("ElementId", "MonsterId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterElements");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("MonsterID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.HasIndex("MonsterID");

                    b.ToTable("MonsterLocations");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterMove", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("MoveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonsterId");

                    b.HasIndex("MoveId");

                    b.ToTable("MonsterMoves");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MonsterID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MonsterID");

                    b.ToTable("MonsterTitles");
                });

            modelBuilder.Entity("MonHunDex.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("MonHunDex.Models.Location", b =>
                {
                    b.HasOne("MonHunDex.Models.LocationType", "LocationType")
                        .WithMany("Locations")
                        .HasForeignKey("LocationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationType");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterElement", b =>
                {
                    b.HasOne("MonHunDex.Models.Element", "Element")
                        .WithMany("MonsterElements")
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonHunDex.Models.Monster", "Monster")
                        .WithMany("MonsterElements")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterLocation", b =>
                {
                    b.HasOne("MonHunDex.Models.Location", "Location")
                        .WithMany("MonsterLocations")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonHunDex.Models.Monster", "Monster")
                        .WithMany("MonsterLocations")
                        .HasForeignKey("MonsterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterMove", b =>
                {
                    b.HasOne("MonHunDex.Models.Monster", "Monster")
                        .WithMany()
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonHunDex.Models.Move", "Move")
                        .WithMany()
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Monster");

                    b.Navigation("Move");
                });

            modelBuilder.Entity("MonHunDex.Models.MonsterTitle", b =>
                {
                    b.HasOne("MonHunDex.Models.Monster", "Monster")
                        .WithMany()
                        .HasForeignKey("MonsterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("MonHunDex.Models.Element", b =>
                {
                    b.Navigation("MonsterElements");
                });

            modelBuilder.Entity("MonHunDex.Models.Location", b =>
                {
                    b.Navigation("MonsterLocations");
                });

            modelBuilder.Entity("MonHunDex.Models.LocationType", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("MonHunDex.Models.Monster", b =>
                {
                    b.Navigation("MonsterElements");

                    b.Navigation("MonsterLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
