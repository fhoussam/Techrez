﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using angularclient;

namespace angularclient.Migrations
{
    [DbContext(typeof(JhDbContext))]
    partial class JhDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("jh.Entities.CachedUrl", b =>
                {
                    b.Property<int>("CachedUrlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("SearchJobId")
                        .HasColumnType("int");

                    b.HasKey("CachedUrlId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("SearchJobId");

                    b.ToTable("CachedUrls");
                });

            modelBuilder.Entity("jh.Entities.DescriptionUrlTransformer", b =>
                {
                    b.Property<int>("DescriptionUrlTransformerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Replacer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescriptionUrlTransformerId");

                    b.HasIndex("ProviderId");

                    b.ToTable("DescriptionUrlTransformers");
                });

            modelBuilder.Entity("jh.Entities.Keyword", b =>
                {
                    b.Property<int>("KeywordId")
                        .HasColumnType("int");

                    b.Property<int>("KeywordType")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeywordId");

                    b.ToTable("Keywords");

                    b.HasData(
                        new
                        {
                            KeywordId = 1,
                            KeywordType = 0,
                            Value = "diversit"
                        },
                        new
                        {
                            KeywordId = 2,
                            KeywordType = 0,
                            Value = "inclusion"
                        },
                        new
                        {
                            KeywordId = 3,
                            KeywordType = 0,
                            Value = "handicap"
                        },
                        new
                        {
                            KeywordId = 4,
                            KeywordType = 0,
                            Value = "discrimination"
                        },
                        new
                        {
                            KeywordId = 5,
                            KeywordType = 0,
                            Value = "égalité"
                        },
                        new
                        {
                            KeywordId = 6,
                            KeywordType = 2,
                            Value = "cdd"
                        },
                        new
                        {
                            KeywordId = 7,
                            KeywordType = 2,
                            Value = "cdi"
                        },
                        new
                        {
                            KeywordId = 8,
                            KeywordType = 2,
                            Value = "intérim"
                        },
                        new
                        {
                            KeywordId = 9,
                            KeywordType = 2,
                            Value = "provisoir"
                        },
                        new
                        {
                            KeywordId = 10,
                            KeywordType = 2,
                            Value = "anglais"
                        },
                        new
                        {
                            KeywordId = 11,
                            KeywordType = 2,
                            Value = "english"
                        },
                        new
                        {
                            KeywordId = 12,
                            KeywordType = 2,
                            Value = "junior"
                        },
                        new
                        {
                            KeywordId = 13,
                            KeywordType = 2,
                            Value = "débutant"
                        },
                        new
                        {
                            KeywordId = 14,
                            KeywordType = 1,
                            Value = "insertion"
                        });
                });

            modelBuilder.Entity("jh.Entities.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int?>("DateExtractor")
                        .HasColumnType("int");

                    b.Property<string>("DatePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmptyPageIndicatorPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsJobIdInQueryParam")
                        .HasColumnType("bit");

                    b.Property<string>("ListUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitlePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrlTransformer")
                        .HasColumnType("int");

                    b.HasKey("ProviderId");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            ProviderId = 1,
                            DatePath = "//div[contains(@class, 'cardOutline')]/div/div[1]/div/div/table[2]/tbody/tr[2]/td/div/span[1]/text()",
                            DescriptionPath = "//div[contains(@id, 'jobDescriptionText')]",
                            EmptyPageIndicatorPath = "//div[contains(@class, 'jobsearch-NoResult-messageHeader')]",
                            IsJobIdInQueryParam = false,
                            ListUrl = "https://fr.indeed.com/jobs?q={keyword}&l=%C3%8Ele-de-France&sort=date",
                            PublisherPath = "//div[contains(@class, 'companyInfo')]/span[1]",
                            TitlePath = "//div[contains(@class, 'cardOutline')]/div/div[1]/div/div/table/tbody/tr/td/div/h2/a",
                            UrlPath = "//div[contains(@class, 'cardOutline')]/div/div[1]/div/div/table/tbody/tr/td/div/h2/a/@href"
                        });
                });

            modelBuilder.Entity("jh.Entities.ResultEntity", b =>
                {
                    b.Property<int>("ResultEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SearchJobId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResultEntityId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("SearchJobId");

                    b.ToTable("ResultEntities");
                });

            modelBuilder.Entity("jh.Entities.SearchJob", b =>
                {
                    b.Property<int>("SearchJobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DurationInMs")
                        .HasColumnType("float");

                    b.Property<DateTime>("SearchDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SearchJobId");

                    b.ToTable("SearchJobs");
                });

            modelBuilder.Entity("jh.Entities.UrlSpecialCharacter", b =>
                {
                    b.Property<int>("UrlSpecialCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Replacer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("UrlSpecialCharacterId");

                    b.HasIndex("ProviderId");

                    b.ToTable("UrlSpecialCharacters");

                    b.HasData(
                        new
                        {
                            UrlSpecialCharacterId = 1,
                            ProviderId = 1,
                            Replacer = "%23",
                            Value = "#"
                        });
                });

            modelBuilder.Entity("jh.Entities.CachedUrl", b =>
                {
                    b.HasOne("jh.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("jh.Entities.SearchJob", "SearchJob")
                        .WithMany()
                        .HasForeignKey("SearchJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jh.Entities.DescriptionUrlTransformer", b =>
                {
                    b.HasOne("jh.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jh.Entities.ResultEntity", b =>
                {
                    b.HasOne("jh.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("jh.Entities.SearchJob", "SearchJob")
                        .WithMany("ResultEntity")
                        .HasForeignKey("SearchJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jh.Entities.UrlSpecialCharacter", b =>
                {
                    b.HasOne("jh.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
