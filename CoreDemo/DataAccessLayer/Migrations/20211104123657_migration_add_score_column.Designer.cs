﻿// <auto-generated />
using System;
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20211104123657_migration_add_score_column")]
    partial class migration_add_score_column
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concreate.About", b =>
                {
                    b.Property<int>("aboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("aboutID");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Blog", b =>
                {
                    b.Property<int>("blogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("blogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("blogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("blogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("blogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("blogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<int>("writerID")
                        .HasColumnType("int");

                    b.HasKey("blogID");

                    b.HasIndex("categoryID");

                    b.HasIndex("writerID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("categoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("categoryID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogScore")
                        .HasColumnType("int");

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<string>("commentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("commentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("commentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("commentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("commentID");

                    b.HasIndex("blogID");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("contactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactMsg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("contactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("contactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("EntityLayer.Concreate.NewsLatter", b =>
                {
                    b.Property<int>("mailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("mailStatus")
                        .HasColumnType("bit");

                    b.HasKey("mailID");

                    b.ToTable("newsLatters");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Writer", b =>
                {
                    b.Property<int>("writerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("writerAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("writerPassword")
                        .HasColumnType("int");

                    b.Property<bool>("writerStatus")
                        .HasColumnType("bit");

                    b.HasKey("writerID");

                    b.ToTable("writers");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concreate.Category", "category")
                        .WithMany("Blogs")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concreate.Writer", "writer")
                        .WithMany("Bloglar")
                        .HasForeignKey("writerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("writer");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concreate.Blog", "Blog")
                        .WithMany("comments")
                        .HasForeignKey("blogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Blog", b =>
                {
                    b.Navigation("comments");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Writer", b =>
                {
                    b.Navigation("Bloglar");
                });
#pragma warning restore 612, 618
        }
    }
}
