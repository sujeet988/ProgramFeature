using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramFeature.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammeDetailsMaster",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammeName = table.Column<string>(maxLength: 100, nullable: false),
                    ProgrammeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Groupid = table.Column<long>(nullable: false),
                    Portfolioid = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 25, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeDetailsMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammeLinkedPojects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammeID = table.Column<long>(nullable: false),
                    LinkedProjects = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeLinkedPojects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammeMasterUsers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammeMasterOwner = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 25, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeMasterUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammeOwners",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammeID = table.Column<long>(nullable: false),
                    ProgrammeOwner = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammePortfolio",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammePortfolio", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammeDetailsMaster");

            migrationBuilder.DropTable(
                name: "ProgrammeLinkedPojects");

            migrationBuilder.DropTable(
                name: "ProgrammeMasterUsers");

            migrationBuilder.DropTable(
                name: "ProgrammeOwners");

            migrationBuilder.DropTable(
                name: "ProgrammePortfolio");
        }
    }
}
