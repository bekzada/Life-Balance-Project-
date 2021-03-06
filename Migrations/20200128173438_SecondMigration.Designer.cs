﻿// <auto-generated />
using System;
using LifeBalance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LifeBalance.Migrations
{
    [DbContext(typeof(HomeContext))]
    [Migration("20200128173438_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LifeBalance.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("LifeBalance.Models.Values", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoordinatorID");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfValue");

                    b.Property<string>("Title1")
                        .IsRequired();

                    b.Property<string>("Title2")
                        .IsRequired();

                    b.Property<string>("Title3")
                        .IsRequired();

                    b.Property<string>("Title4")
                        .IsRequired();

                    b.Property<string>("Title5")
                        .IsRequired();

                    b.Property<string>("Title6")
                        .IsRequired();

                    b.Property<string>("Title7")
                        .IsRequired();

                    b.Property<string>("Title8")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("CoordinatorID");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("LifeBalance.Models.Values", b =>
                {
                    b.HasOne("LifeBalance.Models.User", "Coordinator")
                        .WithMany()
                        .HasForeignKey("CoordinatorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
