// <auto-generated />
using System;
using CandidatesData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandidatesData.Migrations
{
    [DbContext(typeof(CandidateContext))]
    partial class CandidateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandidatesData.Models.BranchHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("CloseTime")
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("OpenTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchHours");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.ToTable("CandidateAssets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CandidateAsset");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CandidateBranches");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("CandidateCards");
                });

            modelBuilder.Entity("CandidatesData.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateAssetId")
                        .HasColumnType("int");

                    b.Property<int?>("CandidateCardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Since")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Until")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateAssetId");

                    b.HasIndex("CandidateCardId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("CandidatesData.Models.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateAssetId")
                        .HasColumnType("int");

                    b.Property<int?>("CandidateCardId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckedIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckedOut")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateAssetId");

                    b.HasIndex("CandidateCardId");

                    b.ToTable("CheckoutHistories");
                });

            modelBuilder.Entity("CandidatesData.Models.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateAssetId")
                        .HasColumnType("int");

                    b.Property<int?>("CandidateCardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoldPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateAssetId");

                    b.HasIndex("CandidateCardId");

                    b.ToTable("Holds");
                });

            modelBuilder.Entity("CandidatesData.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CandidateCardId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeCandidateBranchId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateCardId");

                    b.HasIndex("HomeCandidateBranchId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("CandidatesData.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("CandidatesData.Models.User", b =>
                {
                    b.HasBaseType("CandidatesData.Models.CandidateAsset");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeweyIndex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("CandidatesData.Models.Video", b =>
                {
                    b.HasBaseType("CandidatesData.Models.CandidateAsset");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("CandidatesData.Models.BranchHours", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateBranch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateAsset", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateBranch", "Location")
                        .WithMany("CandidateAssets")
                        .HasForeignKey("LocationId");

                    b.HasOne("CandidatesData.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Location");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("CandidatesData.Models.Checkout", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateAsset", "CandidateAsset")
                        .WithMany()
                        .HasForeignKey("CandidateAssetId");

                    b.HasOne("CandidatesData.Models.CandidateCard", "CandidateCard")
                        .WithMany("Checkouts")
                        .HasForeignKey("CandidateCardId");

                    b.Navigation("CandidateAsset");

                    b.Navigation("CandidateCard");
                });

            modelBuilder.Entity("CandidatesData.Models.CheckoutHistory", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateAsset", "CandidateAsset")
                        .WithMany()
                        .HasForeignKey("CandidateAssetId");

                    b.HasOne("CandidatesData.Models.CandidateCard", "CandidateCard")
                        .WithMany()
                        .HasForeignKey("CandidateCardId");

                    b.Navigation("CandidateAsset");

                    b.Navigation("CandidateCard");
                });

            modelBuilder.Entity("CandidatesData.Models.Hold", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateAsset", "CandidateAsset")
                        .WithMany()
                        .HasForeignKey("CandidateAssetId");

                    b.HasOne("CandidatesData.Models.CandidateCard", "CandidateCard")
                        .WithMany()
                        .HasForeignKey("CandidateCardId");

                    b.Navigation("CandidateAsset");

                    b.Navigation("CandidateCard");
                });

            modelBuilder.Entity("CandidatesData.Models.Patron", b =>
                {
                    b.HasOne("CandidatesData.Models.CandidateCard", "CandidateCard")
                        .WithMany()
                        .HasForeignKey("CandidateCardId");

                    b.HasOne("CandidatesData.Models.CandidateBranch", "HomeCandidateBranch")
                        .WithMany("Patrons")
                        .HasForeignKey("HomeCandidateBranchId");

                    b.Navigation("CandidateCard");

                    b.Navigation("HomeCandidateBranch");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateBranch", b =>
                {
                    b.Navigation("CandidateAssets");

                    b.Navigation("Patrons");
                });

            modelBuilder.Entity("CandidatesData.Models.CandidateCard", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
