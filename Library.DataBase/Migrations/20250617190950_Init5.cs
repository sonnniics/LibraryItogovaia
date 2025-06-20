using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Bronirovana",
                table: "Knigas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bronirovana",
                table: "Knigas");
        }
    }
}
