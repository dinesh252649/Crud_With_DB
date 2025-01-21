﻿// <auto-generated />
using System;
using CRUD_With_DB.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_With_DB.UI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_With_DB.Entity.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateID")
                        .HasColumnType("int");

                   // b.Property<int>("StateIdd")
                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.Countary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                   // b.ToTable("Countaries");
                    b.ToTable("Countary");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContryId")
                        .HasColumnType("int");

                    b.Property<int?>("CountaryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CountaryID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.City", b =>
                {
                    b.HasOne("CRUD_With_DB.Entity.State", "State")
                        .WithMany("Citys")
                        .HasForeignKey("StateID");

                    b.Navigation("State");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.State", b =>
                {
                    b.HasOne("CRUD_With_DB.Entity.Countary", "Countary")
                        .WithMany("States")
                        .HasForeignKey("CountaryID");

                    b.Navigation("Countary");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.Countary", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("CRUD_With_DB.Entity.State", b =>
                {
                    b.Navigation("Citys");
                });
#pragma warning restore 612, 618
        }
    }
}
