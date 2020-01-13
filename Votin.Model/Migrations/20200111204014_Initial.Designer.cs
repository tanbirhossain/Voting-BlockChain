﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Voting.Model.Context;

namespace Voting.Model.Migrations
{
    [DbContext(typeof(BlockchainContext))]
    [Migration("20200111204014_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Voting.Model.Entities.Election", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("Voting.Model.Entities.ElectionCandidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Candidate");

                    b.Property<int>("ElectionId");

                    b.HasKey("Id");

                    b.HasIndex("ElectionId");

                    b.ToTable("ElectionCandidates");
                });

            modelBuilder.Entity("Voting.Model.Entities.ElectionCandidate", b =>
                {
                    b.HasOne("Voting.Model.Entities.Election", "Election")
                        .WithMany("Candidates")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
