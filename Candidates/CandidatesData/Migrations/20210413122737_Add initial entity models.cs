using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidatesData.Migrations
{
    public partial class Addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "CandidateAssets");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "CandidateAssets",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "CandidateAssets",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "CandidateAssets",
                newName: "Director");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "CandidateAssets",
                newName: "Year");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "CandidateAssets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeweyIndex",
                table: "CandidateAssets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CandidateAssets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "CandidateAssets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "CandidateAssets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CandidateAssets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateAssets",
                table: "CandidateAssets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CandidateBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    OpenTime = table.Column<int>(type: "int", nullable: false),
                    CloseTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchHours_CandidateBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "CandidateBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateAssetId = table.Column<int>(type: "int", nullable: true),
                    CandidateCardId = table.Column<int>(type: "int", nullable: true),
                    CheckedOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedIn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_CandidateAssets_CandidateAssetId",
                        column: x => x.CandidateAssetId,
                        principalTable: "CandidateAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_CandidateCards_CandidateCardId",
                        column: x => x.CandidateCardId,
                        principalTable: "CandidateCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateAssetId = table.Column<int>(type: "int", nullable: true),
                    CandidateCardId = table.Column<int>(type: "int", nullable: true),
                    Since = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Until = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_CandidateAssets_CandidateAssetId",
                        column: x => x.CandidateAssetId,
                        principalTable: "CandidateAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checkouts_CandidateCards_CandidateCardId",
                        column: x => x.CandidateCardId,
                        principalTable: "CandidateCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Holds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateAssetId = table.Column<int>(type: "int", nullable: true),
                    CandidateCardId = table.Column<int>(type: "int", nullable: true),
                    HoldPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holds_CandidateAssets_CandidateAssetId",
                        column: x => x.CandidateAssetId,
                        principalTable: "CandidateAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holds_CandidateCards_CandidateCardId",
                        column: x => x.CandidateCardId,
                        principalTable: "CandidateCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidateCardId = table.Column<int>(type: "int", nullable: true),
                    HomeCandidateBranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patrons_CandidateBranches_HomeCandidateBranchId",
                        column: x => x.HomeCandidateBranchId,
                        principalTable: "CandidateBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patrons_CandidateCards_CandidateCardId",
                        column: x => x.CandidateCardId,
                        principalTable: "CandidateCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateAssets_LocationId",
                table: "CandidateAssets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateAssets_StatusId",
                table: "CandidateAssets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_BranchId",
                table: "BranchHours",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_CandidateAssetId",
                table: "CheckoutHistories",
                column: "CandidateAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_CandidateCardId",
                table: "CheckoutHistories",
                column: "CandidateCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CandidateAssetId",
                table: "Checkouts",
                column: "CandidateAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CandidateCardId",
                table: "Checkouts",
                column: "CandidateCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_CandidateAssetId",
                table: "Holds",
                column: "CandidateAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_CandidateCardId",
                table: "Holds",
                column: "CandidateCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_CandidateCardId",
                table: "Patrons",
                column: "CandidateCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_HomeCandidateBranchId",
                table: "Patrons",
                column: "HomeCandidateBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAssets_CandidateBranches_LocationId",
                table: "CandidateAssets",
                column: "LocationId",
                principalTable: "CandidateBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAssets_Statuses_StatusId",
                table: "CandidateAssets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAssets_CandidateBranches_LocationId",
                table: "CandidateAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAssets_Statuses_StatusId",
                table: "CandidateAssets");

            migrationBuilder.DropTable(
                name: "BranchHours");

            migrationBuilder.DropTable(
                name: "CheckoutHistories");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Holds");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "CandidateBranches");

            migrationBuilder.DropTable(
                name: "CandidateCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateAssets",
                table: "CandidateAssets");

            migrationBuilder.DropIndex(
                name: "IX_CandidateAssets_LocationId",
                table: "CandidateAssets");

            migrationBuilder.DropIndex(
                name: "IX_CandidateAssets_StatusId",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "DeweyIndex",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "CandidateAssets");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CandidateAssets");

            migrationBuilder.RenameTable(
                name: "CandidateAssets",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Users",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Users",
                newName: "City");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
