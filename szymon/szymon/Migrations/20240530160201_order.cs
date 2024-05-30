using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace szymon.Migrations
{
    /// <inheritdoc />
    public partial class order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItem",
                newName: "ShoppingCartItems");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ShoppingCartItems",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderViewModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartItem");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ShoppingCartItem",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem",
                column: "Id");
        }
    }
}
