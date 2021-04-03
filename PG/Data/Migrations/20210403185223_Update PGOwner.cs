using Microsoft.EntityFrameworkCore.Migrations;

namespace PG.Data.Migrations
{
    public partial class UpdatePGOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pg_Owners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pg_Owners");
        }
    }
}
