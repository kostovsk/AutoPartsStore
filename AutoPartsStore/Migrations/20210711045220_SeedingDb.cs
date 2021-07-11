using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsStore.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Brakes" },
                    { 2, null, "Engine" },
                    { 3, null, "Suspension" },
                    { 4, null, "Exhaust" },
                    { 5, null, "Air Conditioning" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Z16 Evolution Ceramic brake pads are the affordable stock replacement for your daily driven vehicle. The low dust Ceramic formula is validated through on-vehicle 3rd party tests in the USA to keep your wheels looking like new.", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", true, false, "POWER STOP 16537 Z16", 18.22m },
                    { 2, 1, "Wagner® E-Coat Brake rotors are engineered for maximum performance with an E-Shield® protective electro-coating applied to all non-braking surfaces. This black-colored coating prevents corrosion, makes removal for service fast and simple, and is visually attractive for open spoke wheels.", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", true, false, "WAGNER BD126055E Black", 32.79m },
                    { 3, 1, "ACDelco Gold (Professional) Remanufactured Coated Brake Calipers feature a robotic-applied, baked-on zinc plated coating that provides superior rust prevention against harsh environmental elements such as rain, snow, and corrosive road sprays.", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", true, true, "ACDELCO 18FR2479C Gold", 137.79m },
                    { 4, 2, "Beck/Arnley parts meet foreign nameplate OE specifications for form, fit and function. Their product specialists work with a network of global sourcing partners so you can install the right part with confidence.", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", true, false, "BECK/ARNLEY 1041999", 60.79m },
                    { 5, 2, "Melling is a leader in engineering design, development, prototype, testing and assembly of fluid delivery products and related items for the automotive OEM industry as well as the aftermarket industry.", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", true, true, "MELLING 31035S", 125.79m },
                    { 6, 2, "Melling is a leader in engineering design, development, prototype, testing and assembly of fluid delivery products and related items for the automotive OEM industry as well as the aftermarket industry.", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", true, false, "MELLING M532", 180.79m },
                    { 7, 3, "MOOG® products incorporate proven design and engineering features for like new steering, ease of installation and longer life. MOOG is the preferred steering and suspension brand of professional technicians and NASCAR crew chiefs.", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", true, false, "MOOG K500069", 28.99m },
                    { 8, 3, "The ACDelco Professional Suspension Stabilizer Bar Link Kit comes with everything you need to easily install new suspension stabilizer bar links, and is a high quality replacement for many vehicles on the road today.", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", true, false, "ACDELCO 45G0452", 19.99m },
                    { 9, 3, "Precisely calibrated to meet the OE design, each application-specific coil spring type is engineered to restore ride height and support the vehicle’s weight. Protective coating resists rust and corrosion while salt spray testing ensures it’s ready for the elements", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", true, false, "MONROE 172286", 110.99m },
                    { 10, 4, "Walker Ultra® Catalytic Converters are design-validated for assured fit, and provide EPA-compliant performance. Premium substrate material and a high-technology washcoat ensure exceptional oxygen storage capacity while OE expertise.", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", true, true, "WALKER 16448 Ultra", 540.79m },
                    { 11, 4, "Delphi exhaust gas recirculation (EGR) valves are a 100 percent OE line, providing an exact fit without the need for orifice washers or clocking for fast, easy installation.", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", true, false, "DELPHI EG10499", 85.79m },
                    { 12, 4, "Walker Quiet-Flow Mufflers feature 100% Structural Stainless Steel construction to resist rust-out three times longer than competitors' premium aluminized mufflers.", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", true, false, "WALKER 54668", 92.89m },
                    { 13, 5, "Manufactured and tested to the strictest OE standards for unparalleled performance. OE - specified O - rings & seals are compatible with both R12 and R134a refrigerants", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", "https://www.rockauto.com/info/14/471-7054__ra_p.jpg", true, true, "DENSO 4717054", 259.99m },
                    { 14, 5, "Old Refrigerant must be removed from the system in accordance with local, state, and federal laws. Replace the A / C Line O - Rings connected to the A / C Condenser to prevent a Refrigerant leak.", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", "https://www.rockauto.com/info/881/10484_1_wm__ra_p.jpg", true, false, "CSF 10484", 61.79m },
                    { 15, 5, "Accumulators and receiver driers play an important part in the automotive air conditioning system. They are designed to hold a little extra refrigerant for hot days as well as having desiccant inside.", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", "https://www.rockauto.com/info/577/1411667-1__ra_p.jpg", true, false, "GPD 1411667", 10.17m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
