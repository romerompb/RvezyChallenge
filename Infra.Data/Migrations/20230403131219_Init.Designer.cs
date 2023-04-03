﻿// <auto-generated />
using System;
using Infra.Data.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Data.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230403131219_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infra.Data.Models.Calendar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit")
                        .HasColumnName("available");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<long>("ListingId")
                        .HasColumnType("bigint")
                        .HasColumnName("listing_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("pk_calendars");

                    b.HasIndex("ListingId")
                        .HasDatabaseName("ix_calendars_listing_id");

                    b.ToTable("calendars", (string)null);
                });

            modelBuilder.Entity("Infra.Data.Models.Listing", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("ListingUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("listing_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("property_type");

                    b.HasKey("Id")
                        .HasName("pk_listings");

                    b.ToTable("listings", (string)null);
                });

            modelBuilder.Entity("Infra.Data.Models.Review", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comments");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<long>("ListingId")
                        .HasColumnType("bigint")
                        .HasColumnName("listing_id");

                    b.Property<long>("ReviewerId")
                        .HasColumnType("bigint")
                        .HasColumnName("reviewer_id");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reviewer_name");

                    b.HasKey("Id")
                        .HasName("pk_reviews");

                    b.HasIndex("ListingId")
                        .HasDatabaseName("ix_reviews_listing_id");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("Infra.Data.Models.Calendar", b =>
                {
                    b.HasOne("Infra.Data.Models.Listing", "Listing")
                        .WithMany("Calendars")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_calendars_listings_listing_id");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("Infra.Data.Models.Review", b =>
                {
                    b.HasOne("Infra.Data.Models.Listing", "Listing")
                        .WithMany("Reviews")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reviews_listings_listing_id");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("Infra.Data.Models.Listing", b =>
                {
                    b.Navigation("Calendars");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}