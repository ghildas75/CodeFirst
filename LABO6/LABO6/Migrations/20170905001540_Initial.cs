using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LABO6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CliDateNaiss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CliNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliPrenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliRue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliVille = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
