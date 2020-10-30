using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_products_productCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "productCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productPictures",
                columns: table => new
                {
                    ProductPictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureLocation = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productPictures", x => x.ProductPictureId);
                    table.ForeignKey(
                        name: "FK_productPictures_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "productPictures",
                columns: new[] { "ProductPictureId", "PictureLocation", "ProductId" },
                values: new object[,]
                {
                    { 100, "https://via.placeholder.com/150", null },
                    { 27, "https://via.placeholder.com/150", null },
                    { 28, "https://via.placeholder.com/150", null },
                    { 29, "https://via.placeholder.com/150", null },
                    { 30, "https://via.placeholder.com/150", null },
                    { 31, "https://via.placeholder.com/150", null },
                    { 32, "https://via.placeholder.com/150", null },
                    { 33, "https://via.placeholder.com/150", null },
                    { 34, "https://via.placeholder.com/150", null },
                    { 35, "https://via.placeholder.com/150", null },
                    { 36, "https://via.placeholder.com/150", null },
                    { 37, "https://via.placeholder.com/150", null },
                    { 38, "https://via.placeholder.com/150", null },
                    { 39, "https://via.placeholder.com/150", null },
                    { 40, "https://via.placeholder.com/150", null },
                    { 41, "https://via.placeholder.com/150", null },
                    { 42, "https://via.placeholder.com/150", null },
                    { 43, "https://via.placeholder.com/150", null },
                    { 44, "https://via.placeholder.com/150", null },
                    { 45, "https://via.placeholder.com/150", null },
                    { 46, "https://via.placeholder.com/150", null },
                    { 47, "https://via.placeholder.com/150", null },
                    { 26, "https://via.placeholder.com/150", null },
                    { 48, "https://via.placeholder.com/150", null },
                    { 25, "https://via.placeholder.com/150", null },
                    { 23, "https://via.placeholder.com/150", null },
                    { 2, "https://via.placeholder.com/150", null },
                    { 3, "https://via.placeholder.com/150", null },
                    { 4, "https://via.placeholder.com/150", null },
                    { 5, "https://via.placeholder.com/150", null },
                    { 6, "https://via.placeholder.com/150", null },
                    { 7, "https://via.placeholder.com/150", null },
                    { 8, "https://via.placeholder.com/150", null },
                    { 9, "https://via.placeholder.com/150", null },
                    { 10, "https://via.placeholder.com/150", null },
                    { 11, "https://via.placeholder.com/150", null },
                    { 12, "https://via.placeholder.com/150", null },
                    { 13, "https://via.placeholder.com/150", null },
                    { 14, "https://via.placeholder.com/150", null },
                    { 15, "https://via.placeholder.com/150", null },
                    { 16, "https://via.placeholder.com/150", null },
                    { 17, "https://via.placeholder.com/150", null },
                    { 18, "https://via.placeholder.com/150", null },
                    { 19, "https://via.placeholder.com/150", null },
                    { 20, "https://via.placeholder.com/150", null },
                    { 21, "https://via.placeholder.com/150", null },
                    { 22, "https://via.placeholder.com/150", null },
                    { 24, "https://via.placeholder.com/150", null },
                    { 49, "https://via.placeholder.com/150", null },
                    { 50, "https://via.placeholder.com/150", null },
                    { 51, "https://via.placeholder.com/150", null },
                    { 78, "https://via.placeholder.com/150", null },
                    { 79, "https://via.placeholder.com/150", null },
                    { 80, "https://via.placeholder.com/150", null },
                    { 81, "https://via.placeholder.com/150", null },
                    { 82, "https://via.placeholder.com/150", null },
                    { 83, "https://via.placeholder.com/150", null },
                    { 84, "https://via.placeholder.com/150", null },
                    { 85, "https://via.placeholder.com/150", null },
                    { 86, "https://via.placeholder.com/150", null },
                    { 87, "https://via.placeholder.com/150", null },
                    { 88, "https://via.placeholder.com/150", null },
                    { 89, "https://via.placeholder.com/150", null },
                    { 90, "https://via.placeholder.com/150", null },
                    { 91, "https://via.placeholder.com/150", null },
                    { 92, "https://via.placeholder.com/150", null },
                    { 93, "https://via.placeholder.com/150", null },
                    { 94, "https://via.placeholder.com/150", null },
                    { 95, "https://via.placeholder.com/150", null },
                    { 96, "https://via.placeholder.com/150", null },
                    { 97, "https://via.placeholder.com/150", null },
                    { 98, "https://via.placeholder.com/150", null },
                    { 77, "https://via.placeholder.com/150", null },
                    { 76, "https://via.placeholder.com/150", null },
                    { 75, "https://via.placeholder.com/150", null },
                    { 74, "https://via.placeholder.com/150", null },
                    { 52, "https://via.placeholder.com/150", null },
                    { 53, "https://via.placeholder.com/150", null },
                    { 54, "https://via.placeholder.com/150", null },
                    { 55, "https://via.placeholder.com/150", null },
                    { 56, "https://via.placeholder.com/150", null },
                    { 57, "https://via.placeholder.com/150", null },
                    { 58, "https://via.placeholder.com/150", null },
                    { 59, "https://via.placeholder.com/150", null },
                    { 60, "https://via.placeholder.com/150", null },
                    { 61, "https://via.placeholder.com/150", null },
                    { 1, "https://via.placeholder.com/150", null },
                    { 62, "https://via.placeholder.com/150", null },
                    { 64, "https://via.placeholder.com/150", null },
                    { 65, "https://via.placeholder.com/150", null },
                    { 66, "https://via.placeholder.com/150", null },
                    { 67, "https://via.placeholder.com/150", null },
                    { 68, "https://via.placeholder.com/150", null },
                    { 69, "https://via.placeholder.com/150", null },
                    { 70, "https://via.placeholder.com/150", null },
                    { 71, "https://via.placeholder.com/150", null },
                    { 72, "https://via.placeholder.com/150", null },
                    { 73, "https://via.placeholder.com/150", null },
                    { 63, "https://via.placeholder.com/150", null },
                    { 99, "https://via.placeholder.com/150", null }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "ProductCategoryId" },
                values: new object[,]
                {
                    { 100, 1, "Product 100", 120m, null },
                    { 98, 2, "Product 98", 118m, null },
                    { 27, 2, "Product 27", 47m, null },
                    { 28, 5, "Product 28", 48m, null },
                    { 29, 1, "Product 29", 49m, null },
                    { 30, 2, "Product 30", 50m, null },
                    { 31, 1, "Product 31", 51m, null },
                    { 32, 5, "Product 32", 52m, null },
                    { 33, 5, "Product 33", 53m, null },
                    { 34, 1, "Product 34", 54m, null },
                    { 35, 4, "Product 35", 55m, null },
                    { 36, 5, "Product 36", 56m, null },
                    { 37, 2, "Product 37", 57m, null },
                    { 38, 2, "Product 38", 58m, null },
                    { 39, 1, "Product 39", 59m, null },
                    { 40, 3, "Product 40", 60m, null },
                    { 41, 5, "Product 41", 61m, null },
                    { 42, 5, "Product 42", 62m, null },
                    { 43, 2, "Product 43", 63m, null },
                    { 44, 3, "Product 44", 64m, null },
                    { 45, 5, "Product 45", 65m, null },
                    { 46, 3, "Product 46", 66m, null },
                    { 47, 3, "Product 47", 67m, null },
                    { 26, 1, "Product 26", 46m, null },
                    { 48, 4, "Product 48", 68m, null },
                    { 25, 3, "Product 25", 45m, null },
                    { 23, 5, "Product 23", 43m, null },
                    { 2, 3, "Product 2", 22m, null },
                    { 3, 4, "Product 3", 23m, null },
                    { 4, 5, "Product 4", 24m, null },
                    { 5, 2, "Product 5", 25m, null },
                    { 6, 2, "Product 6", 26m, null },
                    { 7, 1, "Product 7", 27m, null },
                    { 8, 4, "Product 8", 28m, null },
                    { 9, 3, "Product 9", 29m, null },
                    { 10, 1, "Product 10", 30m, null },
                    { 11, 4, "Product 11", 31m, null },
                    { 12, 2, "Product 12", 32m, null },
                    { 13, 4, "Product 13", 33m, null },
                    { 14, 5, "Product 14", 34m, null },
                    { 15, 2, "Product 15", 35m, null },
                    { 16, 5, "Product 16", 36m, null },
                    { 17, 5, "Product 17", 37m, null },
                    { 18, 4, "Product 18", 38m, null },
                    { 19, 1, "Product 19", 39m, null },
                    { 20, 3, "Product 20", 40m, null },
                    { 21, 3, "Product 21", 41m, null },
                    { 22, 4, "Product 22", 42m, null },
                    { 24, 3, "Product 24", 44m, null },
                    { 99, 3, "Product 99", 119m, null },
                    { 49, 1, "Product 49", 69m, null },
                    { 51, 3, "Product 51", 71m, null },
                    { 77, 2, "Product 77", 97m, null },
                    { 78, 3, "Product 78", 98m, null },
                    { 79, 3, "Product 79", 99m, null },
                    { 80, 5, "Product 80", 100m, null },
                    { 81, 3, "Product 81", 101m, null },
                    { 82, 3, "Product 82", 102m, null },
                    { 83, 4, "Product 83", 103m, null },
                    { 84, 3, "Product 84", 104m, null },
                    { 85, 5, "Product 85", 105m, null },
                    { 86, 5, "Product 86", 106m, null },
                    { 87, 1, "Product 87", 107m, null },
                    { 88, 2, "Product 88", 108m, null },
                    { 89, 2, "Product 89", 109m, null },
                    { 90, 2, "Product 90", 110m, null },
                    { 91, 3, "Product 91", 111m, null },
                    { 92, 1, "Product 92", 112m, null },
                    { 93, 5, "Product 93", 113m, null },
                    { 94, 5, "Product 94", 114m, null },
                    { 95, 3, "Product 95", 115m, null },
                    { 96, 3, "Product 96", 116m, null },
                    { 97, 2, "Product 97", 117m, null },
                    { 76, 3, "Product 76", 96m, null },
                    { 50, 3, "Product 50", 70m, null },
                    { 75, 4, "Product 75", 95m, null },
                    { 73, 3, "Product 73", 93m, null },
                    { 52, 1, "Product 52", 72m, null },
                    { 53, 5, "Product 53", 73m, null },
                    { 54, 3, "Product 54", 74m, null },
                    { 55, 4, "Product 55", 75m, null },
                    { 56, 3, "Product 56", 76m, null },
                    { 57, 3, "Product 57", 77m, null },
                    { 58, 2, "Product 58", 78m, null },
                    { 59, 2, "Product 59", 79m, null },
                    { 60, 2, "Product 60", 80m, null },
                    { 61, 1, "Product 61", 81m, null },
                    { 62, 2, "Product 62", 82m, null },
                    { 63, 4, "Product 63", 83m, null },
                    { 64, 1, "Product 64", 84m, null },
                    { 65, 5, "Product 65", 85m, null },
                    { 66, 5, "Product 66", 86m, null },
                    { 67, 2, "Product 67", 87m, null },
                    { 68, 4, "Product 68", 88m, null },
                    { 69, 1, "Product 69", 89m, null },
                    { 70, 2, "Product 70", 90m, null },
                    { 71, 3, "Product 71", 91m, null },
                    { 72, 4, "Product 72", 92m, null },
                    { 74, 3, "Product 74", 94m, null },
                    { 1, 1, "Product 1", 21m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_productPictures_ProductId",
                table: "productPictures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductCategoryId",
                table: "products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productPictures");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "productCategories");
        }
    }
}
