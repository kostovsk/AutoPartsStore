using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsStore.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/568/16-537__ra_p.jpg", "https://www.rockauto.com/info/568/16-537__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/5/MWG_BD126055E_P04_ANG__ra_p.jpg", "https://www.rockauto.com/info/5/MWG_BD126055E_P04_ANG__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/314/18FR2479C_Primary__ra_p.jpg", "https://www.rockauto.com/info/314/18FR2479C_Primary__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/31/BA1041999-1__ra_p.jpg", "https://www.rockauto.com/info/31/BA1041999-1__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg", "https://www.rockauto.com/info/583/3-1035S-1-KIT__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/583/M532-1-FRO__ra_p.jpg", "https://www.rockauto.com/info/583/M532-1-FRO__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/11/AMG_K500069_P04_ANG__ra_p.jpg", "https://www.rockauto.com/info/11/AMG_K500069_P04_ANG__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/345/45G0452_Primary__ra_p.jpg", "https://www.rockauto.com/info/345/45G0452_Primary__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/904/172287__ra_p.jpg", "https://www.rockauto.com/info/904/172287__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/9/BDCN_16448_P04_FRO__ra_p.jpg", "https://www.rockauto.com/info/9/BDCN_16448_P04_FRO__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/43/EG10499K__ra_p.jpg", "https://www.rockauto.com/info/43/EG10499K__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/9/BDCN_54668_P04_FRO__ra_p.jpg", "https://www.rockauto.com/info/9/BDCN_54668_P04_FRO__ra_p.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_PartId",
                table: "ShoppingCartItems",
                column: "PartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg" });
        }
    }
}
