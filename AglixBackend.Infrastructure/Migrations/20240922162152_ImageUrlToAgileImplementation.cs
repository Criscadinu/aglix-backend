using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AglixBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrlToAgileImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AgileImplementation",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AgileImplementation");
        }
    }
}
