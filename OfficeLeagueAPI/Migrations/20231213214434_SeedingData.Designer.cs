﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OfficeLeagueAPI.Models;

#nullable disable

namespace OfficeLeagueAPI.Migrations
{
    [DbContext(typeof(PremierLeagueDbContext))]
    [Migration("20231213214434_SeedingData")]
    partial class SeedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OfficeLeagueAPI.Models.Contestant", b =>
                {
                    b.Property<int>("ContestantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContestantId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ContestantId");

                    b.ToTable("Contestants", (string)null);

                    b.HasData(
                        new
                        {
                            ContestantId = 1,
                            Age = 25,
                            FirstName = "Jaksa",
                            IsAdmin = true,
                            LastName = "Cukic",
                            Nickname = "Caksa"
                        },
                        new
                        {
                            ContestantId = 2,
                            Age = 23,
                            FirstName = "Gligorije",
                            IsAdmin = true,
                            LastName = "Petrovic",
                            Nickname = "Gypsy king"
                        },
                        new
                        {
                            ContestantId = 3,
                            Age = 26,
                            FirstName = "Srdjan",
                            IsAdmin = true,
                            LastName = "Todorovic",
                            Nickname = "Srdzan"
                        },
                        new
                        {
                            ContestantId = 4,
                            Age = 23,
                            FirstName = "Vuk",
                            IsAdmin = true,
                            LastName = "Trifunovic",
                            Nickname = "Csni"
                        });
                });

            modelBuilder.Entity("OfficeLeagueAPI.Models.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"));

                    b.Property<int>("DailyLimit")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("Points")
                        .HasColumnType("real");

                    b.HasKey("DisciplineId");

                    b.ToTable("Disciplines", (string)null);

                    b.HasData(
                        new
                        {
                            DisciplineId = 10,
                            DailyLimit = 1,
                            Description = "3UP description",
                            Name = "3UP",
                            Points = 1.5f
                        },
                        new
                        {
                            DisciplineId = 11,
                            DailyLimit = 1,
                            Description = "Football Dice description",
                            Name = "Footbal Dice",
                            Points = 1.25f
                        },
                        new
                        {
                            DisciplineId = 12,
                            DailyLimit = 4,
                            Description = "Uno description",
                            Name = "Uno",
                            Points = 1f
                        },
                        new
                        {
                            DisciplineId = 13,
                            DailyLimit = 1,
                            Description = "Darts description",
                            Name = "Darts",
                            Points = 1f
                        });
                });

            modelBuilder.Entity("OfficeLeagueAPI.Models.OfficePremierLeagueScoreboard", b =>
                {
                    b.Property<int>("ScoreboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreboardId"));

                    b.Property<int>("ContestantId")
                        .HasColumnType("int");

                    b.Property<int>("DateDisciplinePlayed")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeDisciplineFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeDisciplineStarted")
                        .HasColumnType("datetime2");

                    b.HasKey("ScoreboardId");

                    b.ToTable("Scoreboards");
                });
#pragma warning restore 612, 618
        }
    }
}
