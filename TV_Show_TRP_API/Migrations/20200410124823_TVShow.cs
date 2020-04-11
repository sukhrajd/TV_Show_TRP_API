using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace TV_Show_TRP_API.Migrations
{
    public partial class TVShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVShow_TRP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Show_Name = table.Column<string>(nullable: true),
                    Channel_Name = table.Column<string>(nullable: true),
                    Producer_Name = table.Column<string>(nullable: true),
                    Show_TRP = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShow_TRP", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScript", @"DataQueries.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TVShow_TRP");
        }
    }
}
