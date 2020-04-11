﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TV_Show_TRP_API.Data;

namespace TV_Show_TRP_API.Migrations
{
    [DbContext(typeof(TV_Show_TRP_APIContext))]
    [Migration("20200410124823_TVShow")]
    partial class TVShow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TV_Show_TRP_API.Models.TVShow_TRP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Channel_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Show_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Show_TRP")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TVShow_TRP");
                });
#pragma warning restore 612, 618
        }
    }
}