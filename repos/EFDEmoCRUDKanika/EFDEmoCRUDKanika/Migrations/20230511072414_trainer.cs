using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDEmoCRUDKanika.Migrations
{
    /// <inheritdoc />
    public partial class trainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "trainer",
                table: "Batches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trainer",
                table: "Batches");
        }
    }
}
