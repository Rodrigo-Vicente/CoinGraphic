﻿// <auto-generated />
using System;
using CoinGraphic.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoinGraphic.Migrations
{
    [DbContext(typeof(ADDContext))]
    partial class ADDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoinGraphic.Models.CoinHistoric5Y", b =>
                {
                    b.Property<Guid>("CoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("price_close")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_high")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_low")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_open")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("time_close")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("volume_traded")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CoinId");

                    b.ToTable("CoinHistoric5ys");
                });

            modelBuilder.Entity("CoinGraphic.Models.CoinHistoricLast30Days", b =>
                {
                    b.Property<Guid>("CoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("price_close")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_high")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_low")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("price_open")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("time_close")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("volume_traded")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CoinId");

                    b.ToTable("CoinHistoricLast30Days");
                });
#pragma warning restore 612, 618
        }
    }
}