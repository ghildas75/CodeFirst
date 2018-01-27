using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication2.Migrations
{
    public partial class first2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CliNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliPrenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliRue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliVille = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliDateNaiss = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
