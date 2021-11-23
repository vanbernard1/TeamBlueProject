﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamBlueProject.Models;

namespace TeamBlueProject.Migrations
{
    [DbContext(typeof(CLODbContext))]
    partial class CLODbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TeamBlueProject.Models.CLO", b =>
                {
                    b.Property<int>("CLOId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Objective")
                        .HasColumnType("TEXT");

                    b.HasKey("CLOId");

                    b.ToTable("CLOs");
                });
#pragma warning restore 612, 618
        }
    }
}