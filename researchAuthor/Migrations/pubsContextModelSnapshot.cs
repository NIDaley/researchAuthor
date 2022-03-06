﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using researchAuthor.Models;

namespace researchAuthor.Migrations
{
    [DbContext(typeof(pubsContext))]
    partial class pubsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("researchAuthor.Models.Author", b =>
                {
                    b.Property<string>("AuId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("au_id");

                    b.Property<string>("Address")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("address");

                    b.Property<string>("AuFname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("au_fname");

                    b.Property<string>("AuLname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("au_lname");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<bool>("Contract")
                        .HasColumnType("bit")
                        .HasColumnName("contract");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("phone")
                        .HasDefaultValueSql("('UNKNOWN')")
                        .IsFixedLength(true);

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.Property<string>("Zip")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength(true);

                    b.HasKey("AuId")
                        .HasName("UPKCL_auidind");

                    b.HasIndex(new[] { "AuLname", "AuFname" }, "aunmind");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("researchAuthor.Models.Discount", b =>
                {
                    b.Property<decimal>("Discount1")
                        .HasColumnType("decimal(4,2)")
                        .HasColumnName("discount");

                    b.Property<string>("Discounttype")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("discounttype");

                    b.Property<short?>("Highqty")
                        .HasColumnType("smallint")
                        .HasColumnName("highqty");

                    b.Property<short?>("Lowqty")
                        .HasColumnType("smallint")
                        .HasColumnName("lowqty");

                    b.Property<string>("StorId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength(true);

                    b.HasIndex("StorId");

                    b.ToTable("discounts");
                });

            modelBuilder.Entity("researchAuthor.Models.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("char(9)")
                        .HasColumnName("emp_id")
                        .IsFixedLength(true);

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("fname");

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("hire_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("job_id")
                        .HasDefaultValueSql("((1))");

                    b.Property<byte?>("JobLvl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("job_lvl")
                        .HasDefaultValueSql("((10))");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("lname");

                    b.Property<string>("Minit")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("minit")
                        .IsFixedLength(true);

                    b.Property<string>("PubId")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .HasDefaultValueSql("('9952')")
                        .IsFixedLength(true);

                    b.HasKey("EmpId")
                        .HasName("PK_emp_id")
                        .IsClustered(false);

                    b.HasIndex("JobId");

                    b.HasIndex("PubId");

                    b.HasIndex(new[] { "Lname", "Fname", "Minit" }, "employee_ind")
                        .IsClustered();

                    b.ToTable("employee");
                });

            modelBuilder.Entity("researchAuthor.Models.Job", b =>
                {
                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("job_id")
                        .UseIdentityColumn();

                    b.Property<string>("JobDesc")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("job_desc")
                        .HasDefaultValueSql("('New Position - title not formalized yet')");

                    b.Property<byte>("MaxLvl")
                        .HasColumnType("tinyint")
                        .HasColumnName("max_lvl");

                    b.Property<byte>("MinLvl")
                        .HasColumnType("tinyint")
                        .HasColumnName("min_lvl");

                    b.HasKey("JobId");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("researchAuthor.Models.PubInfo", b =>
                {
                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength(true);

                    b.Property<byte[]>("Logo")
                        .HasColumnType("image")
                        .HasColumnName("logo");

                    b.Property<string>("PrInfo")
                        .HasColumnType("text")
                        .HasColumnName("pr_info");

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubinfo");

                    b.ToTable("pub_info");
                });

            modelBuilder.Entity("researchAuthor.Models.Publisher", b =>
                {
                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength(true);

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("country")
                        .HasDefaultValueSql("('USA')");

                    b.Property<string>("PubName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("pub_name");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubind");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("researchAuthor.Models.Roysched", b =>
                {
                    b.Property<int?>("Hirange")
                        .HasColumnType("int")
                        .HasColumnName("hirange");

                    b.Property<int?>("Lorange")
                        .HasColumnType("int")
                        .HasColumnName("lorange");

                    b.Property<int?>("Royalty")
                        .HasColumnType("int")
                        .HasColumnName("royalty");

                    b.Property<string>("TitleId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.HasIndex(new[] { "TitleId" }, "titleidind");

                    b.ToTable("roysched");
                });

            modelBuilder.Entity("researchAuthor.Models.Sale", b =>
                {
                    b.Property<string>("StorId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength(true);

                    b.Property<string>("OrdNum")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ord_num");

                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<DateTime>("OrdDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ord_date");

                    b.Property<string>("Payterms")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("payterms");

                    b.Property<short>("Qty")
                        .HasColumnType("smallint")
                        .HasColumnName("qty");

                    b.HasKey("StorId", "OrdNum", "TitleId")
                        .HasName("UPKCL_sales");

                    b.HasIndex(new[] { "TitleId" }, "titleidind");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("researchAuthor.Models.Store", b =>
                {
                    b.Property<string>("StorId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("stor_id")
                        .IsFixedLength(true);

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.Property<string>("StorAddress")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("stor_address");

                    b.Property<string>("StorName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("stor_name");

                    b.Property<string>("Zip")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength(true);

                    b.HasKey("StorId")
                        .HasName("UPK_storeid");

                    b.ToTable("stores");
                });

            modelBuilder.Entity("researchAuthor.Models.Title", b =>
                {
                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<decimal?>("Advance")
                        .HasColumnType("money")
                        .HasColumnName("advance");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("notes");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength(true);

                    b.Property<DateTime>("Pubdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("pubdate")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Royalty")
                        .HasColumnType("int")
                        .HasColumnName("royalty");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("type")
                        .HasDefaultValueSql("('UNDECIDED')")
                        .IsFixedLength(true);

                    b.Property<int?>("YtdSales")
                        .HasColumnType("int")
                        .HasColumnName("ytd_sales");

                    b.HasKey("TitleId");

                    b.HasIndex("PubId");

                    b.HasIndex(new[] { "Title1" }, "titleind");

                    b.ToTable("titles");
                });

            modelBuilder.Entity("researchAuthor.Models.Titleauthor", b =>
                {
                    b.Property<string>("AuId")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("au_id");

                    b.Property<string>("TitleId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("title_id");

                    b.Property<byte?>("AuOrd")
                        .HasColumnType("tinyint")
                        .HasColumnName("au_ord");

                    b.Property<int?>("Royaltyper")
                        .HasColumnType("int")
                        .HasColumnName("royaltyper");

                    b.HasKey("AuId", "TitleId")
                        .HasName("UPKCL_taind");

                    b.HasIndex(new[] { "AuId" }, "auidind");

                    b.HasIndex(new[] { "TitleId" }, "titleidind")
                        .HasDatabaseName("titleidind1");

                    b.ToTable("titleauthor");
                });

            modelBuilder.Entity("researchAuthor.Models.Titleview", b =>
                {
                    b.Property<string>("AuLname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("au_lname");

                    b.Property<byte?>("AuOrd")
                        .HasColumnType("tinyint")
                        .HasColumnName("au_ord");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("PubId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("pub_id")
                        .IsFixedLength(true);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("title");

                    b.Property<int?>("YtdSales")
                        .HasColumnType("int")
                        .HasColumnName("ytd_sales");

                    b.ToView("titleview");
                });

            modelBuilder.Entity("researchAuthor.Models.Discount", b =>
                {
                    b.HasOne("researchAuthor.Models.Store", "Stor")
                        .WithMany()
                        .HasForeignKey("StorId")
                        .HasConstraintName("FK__discounts__stor___173876EA");

                    b.Navigation("Stor");
                });

            modelBuilder.Entity("researchAuthor.Models.Employee", b =>
                {
                    b.HasOne("researchAuthor.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__employee__job_id__25869641")
                        .IsRequired();

                    b.HasOne("researchAuthor.Models.Publisher", "Pub")
                        .WithMany("Employees")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__employee__pub_id__286302EC")
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("researchAuthor.Models.PubInfo", b =>
                {
                    b.HasOne("researchAuthor.Models.Publisher", "Pub")
                        .WithOne("PubInfo")
                        .HasForeignKey("researchAuthor.Models.PubInfo", "PubId")
                        .HasConstraintName("FK__pub_info__pub_id__20C1E124")
                        .IsRequired();

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("researchAuthor.Models.Roysched", b =>
                {
                    b.HasOne("researchAuthor.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__roysched__title___15502E78")
                        .IsRequired();

                    b.Navigation("Title");
                });

            modelBuilder.Entity("researchAuthor.Models.Sale", b =>
                {
                    b.HasOne("researchAuthor.Models.Store", "Stor")
                        .WithMany("Sales")
                        .HasForeignKey("StorId")
                        .HasConstraintName("FK__sales__stor_id__1273C1CD")
                        .IsRequired();

                    b.HasOne("researchAuthor.Models.Title", "Title")
                        .WithMany("Sales")
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__sales__title_id__1367E606")
                        .IsRequired();

                    b.Navigation("Stor");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("researchAuthor.Models.Title", b =>
                {
                    b.HasOne("researchAuthor.Models.Publisher", "Pub")
                        .WithMany("Titles")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__titles__pub_id__08EA5793");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("researchAuthor.Models.Titleauthor", b =>
                {
                    b.HasOne("researchAuthor.Models.Author", "Au")
                        .WithMany("Titleauthors")
                        .HasForeignKey("AuId")
                        .HasConstraintName("FK__titleauth__au_id__0CBAE877")
                        .IsRequired();

                    b.HasOne("researchAuthor.Models.Title", "Title")
                        .WithMany("Titleauthors")
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__titleauth__title__0DAF0CB0")
                        .IsRequired();

                    b.Navigation("Au");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("researchAuthor.Models.Author", b =>
                {
                    b.Navigation("Titleauthors");
                });

            modelBuilder.Entity("researchAuthor.Models.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("researchAuthor.Models.Publisher", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("PubInfo");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("researchAuthor.Models.Store", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("researchAuthor.Models.Title", b =>
                {
                    b.Navigation("Sales");

                    b.Navigation("Titleauthors");
                });
#pragma warning restore 612, 618
        }
    }
}
