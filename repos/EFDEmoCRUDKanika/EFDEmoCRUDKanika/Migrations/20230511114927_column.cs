using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDEmoCRUDKanika.Migrations
{
    /// <inheritdoc />
    public partial class column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Batches",
                newName: "BatchName");

            migrationBuilder.AlterColumn<string>(
                name: "BatchName",
                table: "Batches",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BtachCode",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtachCode",
                table: "Batches");

            migrationBuilder.RenameColumn(
                name: "BatchName",
                table: "Batches",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Batches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
