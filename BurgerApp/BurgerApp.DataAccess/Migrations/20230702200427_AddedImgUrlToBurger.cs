using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImgUrlToBurger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Burgers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://rhubarbandcod.com/wp-content/uploads/2022/06/The-Classic-Cheeseburger-1-500x500.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.kitchensanctuary.com/wp-content/uploads/2019/05/Cheesy-Veggie-Burger-Square-1200-500x500.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.vegangrocerystore.com.au/cdn/shop/products/beyondburger_d0846b9c-a82c-4eaa-9f19-ee0be12d6bbc_800x.jpg?v=1624689743");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://d2lswn7b0fl4u2.cloudfront.net/photos/pg-mushroom-swiss-burger-1612796532.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Burgers");
        }
    }
}
