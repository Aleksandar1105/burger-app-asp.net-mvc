using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurgerApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BurgerOrder_Burgers_BurgerId",
                table: "BurgerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_BurgerOrder_Orders_OrderId",
                table: "BurgerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BurgerOrder",
                table: "BurgerOrder");

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumns: new[] { "BurgerId", "OrderId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BurgerOrder",
                table: "BurgerOrder",
                column: "Id");

            migrationBuilder.InsertData(
                table: "BurgerOrder",
                columns: new[] { "Id", "BurgerId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 1, 3 },
                    { 6, 5, 3 },
                    { 7, 2, 4 },
                    { 8, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BurgerOrder_OrderId",
                table: "BurgerOrder",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_BurgerOrder_Burgers_BurgerId",
                table: "BurgerOrder",
                column: "BurgerId",
                principalTable: "Burgers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BurgerOrder_Orders_OrderId",
                table: "BurgerOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BurgerOrder_Burgers_BurgerId",
                table: "BurgerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_BurgerOrder_Orders_OrderId",
                table: "BurgerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BurgerOrder",
                table: "BurgerOrder");

            migrationBuilder.DropIndex(
                name: "IX_BurgerOrder_OrderId",
                table: "BurgerOrder");

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BurgerOrder",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BurgerOrder",
                table: "BurgerOrder",
                columns: new[] { "OrderId", "BurgerId" });

            migrationBuilder.InsertData(
                table: "BurgerOrder",
                columns: new[] { "BurgerId", "OrderId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 1, 3, 4 },
                    { 5, 3, 5 },
                    { 2, 4, 6 },
                    { 3, 5, 7 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BurgerOrder_Burgers_BurgerId",
                table: "BurgerOrder",
                column: "BurgerId",
                principalTable: "Burgers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BurgerOrder_Orders_OrderId",
                table: "BurgerOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
