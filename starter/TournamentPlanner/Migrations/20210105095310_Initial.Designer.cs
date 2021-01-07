﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TournamentPlanner.Data;

namespace TournamentPlanner.Migrations
{
    [DbContext(typeof(TournamentPlannerDbContext))]
    [Migration("20210105095310_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TournamentPlanner.Data.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Player1ID")
                        .HasColumnType("int");

                    b.Property<int>("Player2ID")
                        .HasColumnType("int");

                    b.Property<int>("Round")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Player1ID");

                    b.HasIndex("Player2ID");

                    b.HasIndex("WinnerID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("TournamentPlanner.Data.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TournamentPlanner.Data.Match", b =>
                {
                    b.HasOne("TournamentPlanner.Data.Player", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TournamentPlanner.Data.Player", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TournamentPlanner.Data.Player", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Player1");

                    b.Navigation("Player2");

                    b.Navigation("Winner");
                });
#pragma warning restore 612, 618
        }
    }
}
