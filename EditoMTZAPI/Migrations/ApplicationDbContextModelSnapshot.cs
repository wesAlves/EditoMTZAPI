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

            modelBuilder.Entity("ChapterEbook", b =>
                {
                    b.Property<Guid>("ChaptersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EbooksId")
                        .HasColumnType("uuid");

                    b.HasKey("ChaptersId", "EbooksId");

                    b.HasIndex("EbooksId");

                    b.ToTable("ChapterEbook");
                });

            modelBuilder.Entity("EditoMTZAPI.Models.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("EditoMTZAPI.Models.Ebook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ebooks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afec3f04-c005-40ba-94ae-5d128c0600fc"),
                            Description = "",
                            Language = "",
                            SubTitle = "",
                            Subject = "",
                            Title = "One"
                        },
                        new
                        {
                            Id = new Guid("eb13d5c2-f370-49e9-8fb7-d605a196422c"),
                            Description = "",
                            Language = "",
                            SubTitle = "",
                            Subject = "",
                            Title = "Two"
                        });
                });

            modelBuilder.Entity("EditoMTZAPI.Models.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("ChapterEbook", b =>
                {
                    b.HasOne("EditoMTZAPI.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("ChaptersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EditoMTZAPI.Models.Ebook", null)
                        .WithMany()
                        .HasForeignKey("EbooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
