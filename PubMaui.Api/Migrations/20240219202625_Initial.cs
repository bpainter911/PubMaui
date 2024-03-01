using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PubMaui.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDiscription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerFullName = table.Column<Guid>(type: "uniqueidentifier", maxLength: 90, nullable: false),
                    CustomerEmail = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    CustomerPhNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerCityTown = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    OrderSum = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityTown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RetailPrice = table.Column<double>(type: "float", nullable: false),
                    MenuCategoryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_MenuCategories_MenuCategoryCategoryId",
                        column: x => x.MenuCategoryCategoryId,
                        principalTable: "MenuCategories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    MId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    OrderSum = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    ItemOption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemOptionPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    TotalTax = table.Column<double>(type: "float", nullable: false),
                    TotalOrderSum = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuOptions",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ItemOption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemOptionPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOptions", x => new { x.MenuId, x.ItemOption, x.ItemOptionPrice });
                    table.ForeignKey(
                        name: "FK_MenuOptions_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "CategoryId", "Description", "Image", "MName", "MenuCategoryCategoryId", "RetailPrice" },
                values: new object[,]
                {
                    { 1, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/mozarella.png", "Mozzarella Sticks", null, 13.0 },
                    { 2, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/frenchfriesontable.png", "Basket of Fries", null, 9.0 },
                    { 3, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/picklespears.png", "Dill Pickle Spears", null, 10.0 },
                    { 4, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/latticefries.png", "Loaded Lattice Fries", null, 15.0 },
                    { 5, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/onionrings.png", "Buttermilk Onion Rings", null, 10.0 },
                    { 6, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/montrealpoutine.png", "Montreal Style Poutine", null, 12.0 },
                    { 7, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/sweetpotato.png", "Sweet Potato Fries", null, 10.0 },
                    { 8, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/souponsky.png", "Soup of the Day", null, 8.0 },
                    { 9, "Starter", 1, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/onionsoupontableecu.png", "French Onion Soup", null, 9.0 },
                    { 10, "Salads", 2, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/saladmandarin.png", "Mandarin Salad", null, 15.0 },
                    { 11, "Salads", 2, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/cobbsaladontable.png", "Cobb Salad", null, 17.0 },
                    { 12, "Salads", 2, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/greeklarge.png", "Greek Salad", null, 9.0 },
                    { 13, "Salads", 2, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/caesarsalad.png", "Classic Caesar Salad", null, 9.0 },
                    { 14, "Salads", 2, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/saladhouse.png", "Cookstown House Salad", null, 13.0 },
                    { 15, "Wings", 3, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png", "Wings - Single Order One Pound", null, 19.0 },
                    { 16, "Wings", 3, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png", "Wings - Double Order Two Pounds", null, 37.0 },
                    { 17, "Wings", 3, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png", "Wings - Party Order Three Pounds", null, 50.0 },
                    { 18, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png", "Chicken Fingers and Fries", null, 16.0 },
                    { 19, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/perogi.png", "Ava's Perogies", null, 16.0 },
                    { 20, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/fishontablecu.png", "Beer Battered Fish & Chips", null, 21.0 },
                    { 21, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png", "Chicken Fingers and Fries Buffalo Style", null, 17.0 },
                    { 22, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/quesadilla.png", "Quesadilla", null, 10.0 },
                    { 23, "Pub Favourites", 4, "", "", "Nachos", null, 20.0 },
                    { 24, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/chickentet.png", "Chicken Tetrazzini", null, 19.0 },
                    { 25, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/bangersmash.png", "Bangers and Mash", null, 15.0 },
                    { 26, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/shepherdspie.png", "Shepherds Pie", null, 16.0 },
                    { 27, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/liveronion.png", "Liver and Onions", null, 18.0 },
                    { 28, "Pub Favourites", 4, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/chili.png", "Texas Chili", null, 15.0 },
                    { 29, "Pub Favourites", 4, "", "", "Mushroom Garlic Meatloaf", null, 18.0 },
                    { 30, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/buffalochickenwrap.png", "Chicken Wrap", null, 18.0 },
                    { 31, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png", "Yukon Gold Burger", null, 18.0 },
                    { 32, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerclassic.png", "Cookstown Classic Burger", null, 17.0 },
                    { 33, "Sandwiches and Burgers", 5, "", "", "Classic Clubhouse", null, 18.0 },
                    { 34, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png", "The Cookstown 'BIG' Burger", null, 22.0 },
                    { 35, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/beefdip.png", "Loaded Beef Dip", null, 20.0 },
                    { 36, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerms.png", "Mushroom Swiss Burger", null, 19.5 },
                    { 37, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerblue.png", "The Big Blue Burger", null, 19.5 },
                    { 38, "Sandwiches and Burgers", 5, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/pulledpork.png", "Pulled Pork on a Bun", null, 17.0 },
                    { 39, "Famous Flatbreads", 6, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/mediterrflat.png", "Loaded Flatbread", null, 15.0 },
                    { 40, "Famous Flatbreads", 6, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/flatbreadchick.png", "Chicken & Goat Cheese Flatbread", null, 18.0 },
                    { 41, "Famous Flatbreads", 6, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/bruschetta.png", "Bruschetta", null, 12.0 },
                    { 42, "Famous Flatbreads", 6, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicontable.png", "Cheesy Garlic Flatbread", null, 10.0 },
                    { 43, "Famous Flatbreads", 6, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicwbacon.png", "Cheesy Garlic Flatbread With Bacon", null, 12.0 },
                    { 44, "Cookstown Pub Desserts", 7, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/toffee.png", "Sticky Toffee Pudding Cake", null, 7.0 },
                    { 45, "Cookstown Pub Desserts", 7, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/oreos.png", "Deep Fried Oreos", null, 8.0 },
                    { 46, "Cookstown Pub Desserts", 7, "", "https://github.com/bpainter911/publib/blob/main/ForMaui/brownie.png", "Brownie Bliss", null, 8.0 }
                });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "CategoryId", "Category", "CategoryDiscription" },
                values: new object[,]
                {
                    { 1, "Starters", "" },
                    { 2, "Salads", "" },
                    { 3, "Wings", "" },
                    { 4, "Pub Favourites", "" },
                    { 5, "Sandwiches and Burgers", "" },
                    { 6, "Famous Flatbreads", "" },
                    { 7, "Cookstown Pub Desserts", "" }
                });

            migrationBuilder.InsertData(
                table: "MenuOptions",
                columns: new[] { "ItemOption", "ItemOptionPrice", "MenuId" },
                values: new object[,]
                {
                    { "Add Gravy", 2.0, 2 },
                    { "Make it a Large", 6.0, 12 },
                    { "Make it a Large", 6.0, 13 },
                    { "Add Gravy", 2.0, 15 },
                    { "Samll Baskit of Fries", 6.0, 15 },
                    { "Add Gravy", 2.0, 16 },
                    { "Samll Baskit of Fries", 6.0, 16 },
                    { "Add Gravy", 2.0, 17 },
                    { "Samll Baskit of Fries", 6.0, 17 },
                    { "Add Gravy", 2.0, 18 },
                    { "Add Gravy", 2.0, 20 },
                    { "Add Gravy", 2.0, 21 },
                    { "Add Gravy", 2.0, 30 },
                    { "Add Gravy", 2.0, 31 },
                    { "Add Gravy", 2.0, 32 },
                    { "Add Gravy", 2.0, 33 },
                    { "Add Gravy", 2.0, 34 },
                    { "Add Gravy", 2.0, 35 },
                    { "Add Gravy", 2.0, 36 },
                    { "Add Gravy", 2.0, 37 },
                    { "Add Gravy", 2.0, 38 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuCategoryCategoryId",
                table: "Menu",
                column: "MenuCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuOptions");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "MenuCategories");
        }
    }
}
