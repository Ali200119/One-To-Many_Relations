﻿// <auto-generated />
using System;
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiorello.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230406005404_AddProductsCategoriesAndProductImagesTables")]
    partial class AddProductsCategoriesAndProductImagesTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiorello.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion...",
                            SoftDelete = false,
                            Title = "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>",
                            VideoCover = "h3-video-img.jpg"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Advantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Advantages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AboutId = 1,
                            Description = "Hand picked just for you.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            AboutId = 1,
                            Description = "Unique flower arrangements.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            AboutId = 1,
                            Description = "Best way to say you care.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a smile for you.",
                            SoftDelete = false,
                            Title = "From our Blog"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Date = new DateTime(2019, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",
                            Image = "blog-feature-img-1.jpg",
                            SoftDelete = false,
                            Title = "Flower Power"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Date = new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",
                            Image = "blog-feature-img-2.jpg",
                            SoftDelete = false,
                            Title = "Local Florists"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 1,
                            Date = new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",
                            Image = "blog-feature-img-3.jpg",
                            SoftDelete = false,
                            Title = "Flower Beauty"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Popular",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "Winter",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Name = "Various",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            Name = "Exotic",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            Name = "Greens",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cactuses",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a smile for you.",
                            SoftDelete = false,
                            Title = "Flower Experts"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Instagram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Instagrams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "instagram1.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Image = "instagram2.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Image = "instagram3.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            Image = "instagram4.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            Image = "instagram5.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            Image = "instagram6.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            Image = "instagram7.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            Image = "instagram8.jpg",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ExpertId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpertId = 1,
                            Image = "h3-team-img-1.png",
                            Name = "CRYSTAL BROOKS",
                            Position = "Florist",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            ExpertId = 1,
                            Image = "h3-team-img-2.png",
                            Name = "SHIRLEY HARRIS",
                            Position = "Manager",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            ExpertId = 1,
                            Image = "h3-team-img-3.png",
                            Name = "BEVERLY CLARK",
                            Position = "Florist",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            ExpertId = 1,
                            Image = "h3-team-img-4.png",
                            Name = "AMANDA WATKINS",
                            Position = "Florist",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 6,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "1MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "2MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "3MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "4MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "5MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "6MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "7MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "8MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Count = 20,
                            Description = "Lorem ipsum",
                            Name = "9MAJESTY PALM",
                            Price = 259m,
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsMain = true,
                            Name = "shop-14-img.jpg",
                            ProductId = 1,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            IsMain = false,
                            Name = "shop-13-img.jpg",
                            ProductId = 1,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            IsMain = false,
                            Name = "shop-12-img.jpg",
                            ProductId = 1,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            IsMain = false,
                            Name = "shop-13-img.jpg",
                            ProductId = 2,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            IsMain = true,
                            Name = "shop-14-img.jpg",
                            ProductId = 2,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            IsMain = true,
                            Name = "shop-11-img.jpg",
                            ProductId = 3,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            IsMain = false,
                            Name = "shop-10-img.jpg",
                            ProductId = 3,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            IsMain = false,
                            Name = "shop-9-img.jpg",
                            ProductId = 3,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 9,
                            IsMain = true,
                            Name = "shop-11-img.jpg",
                            ProductId = 4,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 10,
                            IsMain = false,
                            Name = "shop-12-img.jpg",
                            ProductId = 4,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 11,
                            IsMain = true,
                            Name = "shop-10-img.jpg",
                            ProductId = 5,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 12,
                            IsMain = false,
                            Name = "shop-13-img.jpg",
                            ProductId = 5,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 13,
                            IsMain = true,
                            Name = "shop-9-img.jpg",
                            ProductId = 6,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 14,
                            IsMain = false,
                            Name = "shop-14-img.jpg",
                            ProductId = 6,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 15,
                            IsMain = true,
                            Name = "shop-8-img.jpg",
                            ProductId = 7,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 16,
                            IsMain = false,
                            Name = "shop-11-img.jpg",
                            ProductId = 7,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 17,
                            IsMain = false,
                            Name = "shop-9-img.jpg",
                            ProductId = 7,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 18,
                            IsMain = true,
                            Name = "shop-7-img.jpg",
                            ProductId = 8,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 19,
                            IsMain = false,
                            Name = "shop-10-img.jpg",
                            ProductId = 8,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 20,
                            IsMain = true,
                            Name = "shop-14-img.jpg",
                            ProductId = 9,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 21,
                            IsMain = false,
                            Name = "shop-8-img.jpg",
                            ProductId = 9,
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua.",
                            Image = "testimonial-img-1.png",
                            Name = "Anna Barnes",
                            Position = "Florist",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget.",
                            Image = "testimonial-img-2.png",
                            Name = "Jasmine White",
                            Position = "Florist",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h3-slider-background.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Image = "h3-slider-background-2.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Image = "h3-slider-background-3.jpg",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.SliderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignatureImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SliderInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                            SignatureImage = "h2-sign-img.png",
                            SoftDelete = false,
                            Title = "<h1>Send <span>flowers</span> like</h1><h1>you mean it</h1>"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Subscribe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackgroundImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscribes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackgroundImage = "h3-background-img.jpg",
                            SoftDelete = false,
                            Title = "Join The Colorful Bunch!"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Advantage", b =>
                {
                    b.HasOne("Fiorello.Models.About", "About")
                        .WithMany("Advantages")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
                });

            modelBuilder.Entity("Fiorello.Models.BlogPost", b =>
                {
                    b.HasOne("Fiorello.Models.Blog", "Blog")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Fiorello.Models.Person", b =>
                {
                    b.HasOne("Fiorello.Models.Expert", "Expert")
                        .WithMany("Persons")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");
                });

            modelBuilder.Entity("Fiorello.Models.Product", b =>
                {
                    b.HasOne("Fiorello.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Fiorello.Models.ProductImage", b =>
                {
                    b.HasOne("Fiorello.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fiorello.Models.About", b =>
                {
                    b.Navigation("Advantages");
                });

            modelBuilder.Entity("Fiorello.Models.Blog", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("Fiorello.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Fiorello.Models.Expert", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("Fiorello.Models.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
