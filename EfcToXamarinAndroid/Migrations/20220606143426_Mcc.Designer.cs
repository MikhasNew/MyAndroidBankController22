﻿// <auto-generated />
using System;
using EfcToXamarinAndroid.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfcToXamarinAndroid.MigrationsHelper.Migrations
{
    [DbContext(typeof(DataItemContext))]
    [Migration("20220606143426_Mcc")]
    partial class Mcc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("EfcToXamarinAndroid.MicrationsHelper.DataItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("CastomCategoryTyps")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("DefaultCategoryTyps")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripton")
                        .HasColumnType("TEXT");

                    b.Property<long>("HashId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Karta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MCC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OperacionTyp")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Sum")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("EfcToXamarinAndroid.MigrationsHelper.Models.SybCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DataItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DataItemId");

                    b.ToTable("SybCategory");
                });

            modelBuilder.Entity("EfcToXamarinAndroid.MigrationsHelper.Models.SybCategory", b =>
                {
                    b.HasOne("EfcToXamarinAndroid.MicrationsHelper.DataItem", null)
                        .WithMany("SubCategorys")
                        .HasForeignKey("DataItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
