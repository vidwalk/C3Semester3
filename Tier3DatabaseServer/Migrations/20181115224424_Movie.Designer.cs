﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tier3ServerDatabase.database;

namespace Tier3DatabaseServer.Migrations
{
    [DbContext(typeof(DatabaseAdapter))]
    [Migration("20181115224424_Movie")]
    partial class Movie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tier3ServerDatabase.common.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(40);

                    b.Property<string>("NameDirector")
                        .HasMaxLength(20);

                    b.Property<string>("NameMainActor")
                        .HasMaxLength(20);

                    b.Property<string>("NameStudio")
                        .HasMaxLength(20);

                    b.Property<decimal>("Price")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReleaseDate")
                        .HasMaxLength(20);

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("YearCreation")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
