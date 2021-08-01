using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsStore.Migrations
{
    public partial class AddingAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\16-537__ra_p-small.jpg", "\\Images\\16-537__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\MWG_BD126055E_P04_ANG__ra_p-small.jpg", "\\Images\\MWG_BD126055E_P04_ANG__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\18FR2479C_Primary__ra_p-small.jpg", "\\Images\\18FR2479C_Primary__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\BA1041999-1__ra_p-small.jpg", "\\Images\\BA1041999-1__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\3-1035S-1-KIT__ra_p-small.jpg", "\\Images\\3-1035S-1-KIT__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\M532-1-FRO__ra_p-small.jpg", "\\Images\\M532-1-FRO__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\AMG_K500069_P04_ANG__ra_p-small.jpg", "\\Images\\AMG_K500069_P04_ANG__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\45G0452_Primary__ra_p-small.jpg", "\\Images\\45G0452_Primary__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\172287__ra_p-small.jpg", "\\Images\\172287__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\BDCN_16448_P04_FRO__ra_p-small.jpg", "\\Images\\BDCN_16448_P04_FRO__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\EG10499K__ra_p-small.jpg", "\\Images\\EG10499K__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\BDCN_54668_P04_FRO__ra_p-small.jpg", "\\Images\\BDCN_54668_P04_FRO__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\471-7054__ra_p-small.jpg", "\\Images\\471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\10484_1_wm__ra_p-small.jpg", "\\Images\\10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 15,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\1411667-1__ra_p-small.jpg", "\\Images\\1411667-1__ra_p.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PartId",
                table: "OrderDetails",
                column: "PartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

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

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 15,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg" });
        }
    }
}
