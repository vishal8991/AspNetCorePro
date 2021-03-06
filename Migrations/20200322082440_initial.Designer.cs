﻿// <auto-generated />
using System;
using HelloWorldMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HelloWorldMVC.Migrations
{
    [DbContext(typeof(HelloWorldMVCContext))]
    [Migration("20200322082440_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelloWorldMVC.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("genre");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
