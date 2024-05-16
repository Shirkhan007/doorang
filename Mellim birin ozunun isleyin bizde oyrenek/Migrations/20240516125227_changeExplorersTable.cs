using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mellim_birin_ozunun_isleyin_bizde_oyrenek.Migrations
{
    /// <inheritdoc />
    public partial class changeExplorersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Explores");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Explores",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Explores",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Explores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
