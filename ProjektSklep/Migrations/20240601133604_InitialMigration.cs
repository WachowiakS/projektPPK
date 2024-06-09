using System; 
using Microsoft.EntityFrameworkCore.Migrations; 

#nullable disable // Wyłącza obsługę typów dopuszczających wartość null, co jest wymagane dla migracji.

namespace ProjektSklep.Migrations // Przestrzeń nazw dla migracji w projekcie.
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration // Definicja migracji InitialMigration dziedzicząca z klasy Migration.
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) // Metoda definiująca zmiany do zastosowania podczas migracji w górę (aplikowanie migracji).
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles", // Tworzenie tabeli AspNetRoles.
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false), // Kolumna Id typu string.
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna Name typu string z maksymalną długością 256.
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna NormalizedName typu string z maksymalną długością 256.
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true) // Kolumna ConcurrencyStamp typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id); // Ustawienie Id jako klucza głównego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers", // Tworzenie tabeli AspNetUsers.
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false), // Kolumna Id typu string.
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna UserName typu string z maksymalną długością 256.
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna NormalizedUserName typu string z maksymalną długością 256.
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna Email typu string z maksymalną długością 256.
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true), // Kolumna NormalizedEmail typu string z maksymalną długością 256.
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false), // Kolumna EmailConfirmed typu bool.
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true), // Kolumna PasswordHash typu string.
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true), // Kolumna SecurityStamp typu string.
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true), // Kolumna ConcurrencyStamp typu string.
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true), // Kolumna PhoneNumber typu string.
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false), // Kolumna PhoneNumberConfirmed typu bool.
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false), // Kolumna TwoFactorEnabled typu bool.
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true), // Kolumna LockoutEnd typu DateTimeOffset.
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false), // Kolumna LockoutEnabled typu bool.
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false) // Kolumna AccessFailedCount typu int.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id); // Ustawienie Id jako klucza głównego.
                });

            migrationBuilder.CreateTable(
                name: "Carts", // Tworzenie tabeli Carts.
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false) // Kolumna Id typu int.
                        .Annotation("Sqlite:Autoincrement", true), // Ustawienie Id jako kolumny autoincrement.
                    ProductIds = table.Column<string>(type: "TEXT", nullable: false), // Kolumna ProductIds typu string.
                    UserId = table.Column<string>(type: "TEXT", nullable: true), // Kolumna UserId typu string.
                    IsOrdered = table.Column<bool>(type: "INTEGER", nullable: false), // Kolumna IsOrdered typu bool.
                    Sum = table.Column<double>(type: "REAL", nullable: false) // Kolumna Sum typu double.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id); // Ustawienie Id jako klucza głównego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims", // Tworzenie tabeli AspNetRoleClaims.
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false) // Kolumna Id typu int.
                        .Annotation("Sqlite:Autoincrement", true), // Ustawienie Id jako kolumny autoincrement.
                    RoleId = table.Column<string>(type: "TEXT", nullable: false), // Kolumna RoleId typu string.
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true), // Kolumna ClaimType typu string.
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true) // Kolumna ClaimValue typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id); // Ustawienie Id jako klucza głównego.
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId", // Ustawienie klucza obcego do tabeli AspNetRoles.
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims", // Tworzenie tabeli AspNetUserClaims.
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false) // Kolumna Id typu int.
                        .Annotation("Sqlite:Autoincrement", true), // Ustawienie Id jako kolumny autoincrement.
                    UserId = table.Column<string>(type: "TEXT", nullable: false), // Kolumna UserId typu string.
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true), // Kolumna ClaimType typu string.
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true) // Kolumna ClaimValue typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id); // Ustawienie Id jako klucza głównego.
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId", // Ustawienie klucza obcego do tabeli AspNetUsers.
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins", // Tworzenie tabeli AspNetUserLogins.
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false), // Kolumna LoginProvider typu string z maksymalną długością 128.
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false), // Kolumna ProviderKey typu string z maksymalną długością 128.
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true), // Kolumna ProviderDisplayName typu string.
                    UserId = table.Column<string>(type: "TEXT", nullable: false) // Kolumna UserId typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey }); // Ustawienie złożonego klucza głównego na kolumny LoginProvider i ProviderKey.
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId", // Ustawienie klucza obcego do tabeli AspNetUsers.
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles", // Tworzenie tabeli AspNetUserRoles.
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false), // Kolumna UserId typu string.
                    RoleId = table.Column<string>(type: "TEXT", nullable: false) // Kolumna RoleId typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId }); // Ustawienie złożonego klucza głównego na kolumny UserId i RoleId.
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId", // Ustawienie klucza obcego do tabeli AspNetRoles.
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId", // Ustawienie klucza obcego do tabeli AspNetUsers.
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens", // Tworzenie tabeli AspNetUserTokens.
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false), // Kolumna UserId typu string.
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false), // Kolumna LoginProvider typu string z maksymalną długością 128.
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false), // Kolumna Name typu string z maksymalną długością 128.
                    Value = table.Column<string>(type: "TEXT", nullable: true) // Kolumna Value typu string.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name }); // Ustawienie złożonego klucza głównego na kolumny UserId, LoginProvider i Name.
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId", // Ustawienie klucza obcego do tabeli AspNetUsers.
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // Ustawienie usuwania kaskadowego.
                });

            migrationBuilder.CreateTable(
                name: "Products", // Tworzenie tabeli Products.
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false) // Kolumna Id typu int.
                        .Annotation("Sqlite:Autoincrement", true), // Ustawienie Id jako kolumny autoincrement.
                    Name = table.Column<string>(type: "TEXT", nullable: true), // Kolumna Name typu string.
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true), // Kolumna ImageUrl typu string.
                    Price = table.Column<double>(type: "REAL", nullable: false), // Kolumna Price typu double.
                    Count = table.Column<int>(type: "INTEGER", nullable: false), // Kolumna Count typu int.
                    CartId = table.Column<int>(type: "INTEGER", nullable: true) // Kolumna CartId typu int.
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id); // Ustawienie Id jako klucza głównego.
                    table.ForeignKey(
                        name: "FK_Products_Carts_CartId", // Ustawienie klucza obcego do tabeli Carts.
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id"); // Brak usuwania kaskadowego.
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId", // Tworzenie indeksu dla kolumny RoleId w tabeli AspNetRoleClaims.
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex", // Tworzenie unikalnego indeksu dla kolumny NormalizedName w tabeli AspNetRoles.
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId", // Tworzenie indeksu dla kolumny UserId w tabeli AspNetUserClaims.
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId", // Tworzenie indeksu dla kolumny UserId w tabeli AspNetUserLogins.
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId", // Tworzenie indeksu dla kolumny RoleId w tabeli AspNetUserRoles.
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex", // Tworzenie indeksu dla kolumny NormalizedEmail w tabeli AspNetUsers.
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex", // Tworzenie unikalnego indeksu dla kolumny NormalizedUserName w tabeli AspNetUsers.
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId", // Tworzenie indeksu dla kolumny CartId w tabeli Products.
                table: "Products",
                column: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // Metoda definiująca zmiany do zastosowania podczas migracji w dół (cofanie migracji).
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims"); // Usuwanie tabeli AspNetRoleClaims.

            migrationBuilder.DropTable(
                name: "AspNetUserClaims"); // Usuwanie tabeli AspNetUserClaims.

            migrationBuilder.DropTable(
                name: "AspNetUserLogins"); // Usuwanie tabeli AspNetUserLogins.

            migrationBuilder.DropTable(
                name: "AspNetUserRoles"); // Usuwanie tabeli AspNetUserRoles.

            migrationBuilder.DropTable(
                name: "AspNetUserTokens"); // Usuwanie tabeli AspNetUserTokens.

            migrationBuilder.DropTable(
                name: "Products"); // Usuwanie tabeli Products.

            migrationBuilder.DropTable(
                name: "AspNetRoles"); // Usuwanie tabeli AspNetRoles.

            migrationBuilder.DropTable(
                name: "AspNetUsers"); // Usuwanie tabeli AspNetUsers.

            migrationBuilder.DropTable(
                name: "Carts"); // Usuwanie tabeli Carts.
        }
    }
}
