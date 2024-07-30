using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComm_Review_App.Migrations
{
    /// <inheritdoc />
    public partial class added_product_image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProductImageData",
                table: "Products",
                type: "longblob",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImageData",
                table: "Products");
        }
    }
}
