﻿// <auto-generated />
using System;
using EditoMTZAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EditoMTZAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EditoMTZAPI.Models.Ebook", b =>
                {
                    b.Property<Guid>("EbookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EbookName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EbookID");

                    b.ToTable("Ebooks");

                    b.HasData(
                        new
                        {
                            EbookID = new Guid("06dc8af0-cdf1-498c-a021-5d5a4e3d4040"),
                            EbookName = "One"
                        },
                        new
                        {
                            EbookID = new Guid("3db46b91-a907-42b6-9a34-11d88640562f"),
                            EbookName = "Two"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
