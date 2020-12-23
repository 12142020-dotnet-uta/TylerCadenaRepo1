﻿// <auto-generated />
using System;
using Janken.Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Janken.Domain.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Janken.Domain.Models.Choice", b =>
                {
                    b.Property<Guid>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ChoiceId");

                    b.ToTable("Choice");

                    b.HasData(
                        new
                        {
                            ChoiceId = new Guid("cc14662b-70d1-47cc-a007-f9935f269535"),
                            Name = "type",
                            Value = 0
                        },
                        new
                        {
                            ChoiceId = new Guid("a015cbca-5be3-4be9-9840-7b2ea8dbb1d8"),
                            Name = "type",
                            Value = 1
                        },
                        new
                        {
                            ChoiceId = new Guid("d4a3a6c5-b704-4dc1-b3f2-9cb5f5909bc4"),
                            Name = "type",
                            Value = 2
                        },
                        new
                        {
                            ChoiceId = new Guid("048570ac-0f55-4601-8f12-6eb56018ed65"),
                            Name = "type",
                            Value = 3
                        });
                });

            modelBuilder.Entity("Janken.Domain.Models.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Computer")
                        .HasColumnType("bit");

                    b.Property<string>("Handle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            PlayerId = new Guid("60bc35fe-6df3-40c6-bb84-238ba70df681"),
                            Computer = true,
                            Handle = "Computer",
                            Password = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}