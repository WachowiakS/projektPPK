<<<<<<< HEAD
<<<<<<< HEAD
﻿using System; 
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
=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSklep.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductIds = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    IsOrdered = table.Column<bool>(type: "INTEGER", nullable: false),
                    Sum = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
<<<<<<< HEAD
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "RoleNameIndex", // Tworzenie unikalnego indeksu dla kolumny NormalizedName w tabeli AspNetRoles.
=======
                name: "RoleNameIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "RoleNameIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "IX_AspNetUserClaims_UserId", // Tworzenie indeksu dla kolumny UserId w tabeli AspNetUserClaims.
=======
                name: "IX_AspNetUserClaims_UserId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "IX_AspNetUserClaims_UserId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "IX_AspNetUserLogins_UserId", // Tworzenie indeksu dla kolumny UserId w tabeli AspNetUserLogins.
=======
                name: "IX_AspNetUserLogins_UserId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "IX_AspNetUserLogins_UserId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "IX_AspNetUserRoles_RoleId", // Tworzenie indeksu dla kolumny RoleId w tabeli AspNetUserRoles.
=======
                name: "IX_AspNetUserRoles_RoleId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "IX_AspNetUserRoles_RoleId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "EmailIndex", // Tworzenie indeksu dla kolumny NormalizedEmail w tabeli AspNetUsers.
=======
                name: "EmailIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "EmailIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "UserNameIndex", // Tworzenie unikalnego indeksu dla kolumny NormalizedUserName w tabeli AspNetUsers.
=======
                name: "UserNameIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "UserNameIndex",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
<<<<<<< HEAD
                name: "IX_Products_CartId", // Tworzenie indeksu dla kolumny CartId w tabeli Products.
=======
                name: "IX_Products_CartId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
                name: "IX_Products_CartId",
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
                table: "Products",
                column: "CartId");
        }

        /// <inheritdoc />
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");
<<<<<<< HEAD
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
=======
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
        }
    }
}
