﻿
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektSklep.Data;

#nullable disable // Wyłącza typy referencyjne dopuszczające wartość null, które są wymagane w przypadku skryptów migracji.

namespace ProjektSklep.Migrations 
{
    [DbContext(typeof(ApplicationDbContext))] // Specifies that this snapshot is for the ApplicationDbContext.
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot //  Dziedziczy z ModelSnapshot, reprezentujący stan modelu.
    {
        protected override void BuildModel(ModelBuilder modelBuilder) // Builds the model using the ModelBuilder API.
        {
#pragma warning disable 612, 618 // Disables warnings for obsolete API usage.
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1"); // Dodaje adnotację dla wersji EF Core.

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b => // Konfiguruje jednostkę IdentityRole.
            {
                b.Property<string>("Id") // Konfiguruje the Id property.
                    .HasColumnType("TEXT");

                b.Property<string>("ConcurrencyStamp") // Konfiguruje ConcurrencyStamp property.
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("Name") // Konfiguruje Name property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedName") // Konfiguruje NormalizedName property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id"); // Sets the primary key.

                b.HasIndex("NormalizedName") // Adds a unique index on NormalizedName.
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex");

                b.ToTable("AspNetRoles", (string)null); // Maps to the AspNetRoles table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b => // Configures the IdentityRoleClaim entity.
            {
                b.Property<int>("Id") // Configures the Id property.
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType") // Configures the ClaimType property.
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue") // Configures the ClaimValue property.
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId") // Configures the RoleId property.
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id"); // Sets the primary key.

                b.HasIndex("RoleId"); // Adds an index on RoleId.

                b.ToTable("AspNetRoleClaims", (string)null); // Maps to the AspNetRoleClaims table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b => // Configures the IdentityUser entity.
            {
                b.Property<string>("Id") // Configures the Id property.
                    .HasColumnType("TEXT");

                b.Property<int>("AccessFailedCount") // Configures the AccessFailedCount property.
                    .HasColumnType("INTEGER");

                b.Property<string>("ConcurrencyStamp") // Configures the ConcurrencyStamp property.
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("Email") // Configures the Email property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<bool>("EmailConfirmed") // Configures the EmailConfirmed property.
                    .HasColumnType("INTEGER");

                b.Property<bool>("LockoutEnabled") // Configures the LockoutEnabled property.
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset?>("LockoutEnd") // Configures the LockoutEnd property.
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedEmail") // Configures the NormalizedEmail property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedUserName") // Configures the NormalizedUserName property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("PasswordHash") // Configures the PasswordHash property.
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber") // Configures the PhoneNumber property.
                    .HasColumnType("TEXT");

                b.Property<bool>("PhoneNumberConfirmed") // Configures the PhoneNumberConfirmed property.
                    .HasColumnType("INTEGER");

                b.Property<string>("SecurityStamp") // Configures the SecurityStamp property.
                    .HasColumnType("TEXT");

                b.Property<bool>("TwoFactorEnabled") // Configures the TwoFactorEnabled property.
                    .HasColumnType("INTEGER");

                b.Property<string>("UserName") // Configures the UserName property.
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id"); // Sets the primary key.

                b.HasIndex("NormalizedEmail") // Adds an index on NormalizedEmail.
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName") // Adds a unique index on NormalizedUserName.
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex");

                b.ToTable("AspNetUsers", (string)null); // Maps to the AspNetUsers table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b => // Configures the IdentityUserClaim entity.
            {
                b.Property<int>("Id") // Configures the Id property.
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType") // Configures the ClaimType property.
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue") // Configures the ClaimValue property.
                    .HasColumnType("TEXT");

                b.Property<string>("UserId") // Configures the UserId property.
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id"); // Sets the primary key.

                b.HasIndex("UserId"); // Adds an index on UserId.

                b.ToTable("AspNetUserClaims", (string)null); // Maps to the AspNetUserClaims table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b => // Configures the IdentityUserLogin entity.
            {
                b.Property<string>("LoginProvider") // Configures the LoginProvider property.
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderKey") // Configures the ProviderKey property.
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderDisplayName") // Configures the ProviderDisplayName property.
                    .HasColumnType("TEXT");

                b.Property<string>("UserId") // Configures the UserId property.
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("LoginProvider", "ProviderKey"); // Sets the composite primary key.

                b.HasIndex("UserId"); // Adds an index on UserId.

                b.ToTable("AspNetUserLogins", (string)null); // Maps to the AspNetUserLogins table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b => // Configures the IdentityUserRole entity.
            {
                b.Property<string>("UserId") // Configures the UserId property.
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId") // Configures the RoleId property.
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "RoleId"); // Sets the composite primary key.

                b.HasIndex("RoleId"); // Adds an index on RoleId.

                b.ToTable("AspNetUserRoles", (string)null); // Maps to the AspNetUserRoles table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b => // Configures the IdentityUserToken entity.
            {
                b.Property<string>("UserId") // Configures the UserId property.
                    .HasColumnType("TEXT");

                b.Property<string>("LoginProvider") // Configures the LoginProvider property.
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("Name") // Configures the Name property.
                    .HasMaxLength(128)
                    .HasColumnType("TEXT");

                b.Property<string>("Value") // Configures the Value property.
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "LoginProvider", "Name"); // Sets the composite primary key.

                b.ToTable("AspNetUserTokens", (string)null); // Maps to the AspNetUserTokens table.
            });

            modelBuilder.Entity("ProjektSklep.Models.Cart", b => // Configures the Cart entity.
            {
                b.Property<int>("Id") // Configures the Id property.
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsOrdered") // Configures the IsOrdered property.
                    .HasColumnType("INTEGER");

                b.Property<string>("ProductIds") // Configures the ProductIds property.
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<double>("Sum") // Configures the Sum property.
                    .HasColumnType("REAL");

                b.Property<string>("UserId") // Configures the UserId property.
                    .HasColumnType("TEXT");

                b.HasKey("Id"); // Sets the primary key.

                b.ToTable("Carts"); // Maps to the Carts table.
            });

            modelBuilder.Entity("ProjektSklep.Models.Product", b => // Configures the Product entity.
            {
                b.Property<int>("Id") // Configures the Id property.
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int?>("CartId") // Configures the CartId property.
                    .HasColumnType("INTEGER");

                b.Property<int>("Count") // Configures the Count property.
                    .HasColumnType("INTEGER");

                b.Property<string>("ImageUrl") // Configures the ImageUrl property.
                    .HasColumnType("TEXT");

                b.Property<string>("Name") // Configures the Name property.
                    .HasColumnType("TEXT");

                b.Property<double>("OldPrice") // Configures the OldPrice property.
                    .HasColumnType("REAL");

                b.Property<double>("Price") // Configures the Price property.
                    .HasColumnType("REAL");

                b.HasKey("Id"); // Sets the primary key.

                b.HasIndex("CartId"); // Adds an index on CartId.

                b.ToTable("Products"); // Maps to the Products table.
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b => // Configures the relationships for IdentityRoleClaim.
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b => // Configures the relationships for IdentityUserClaim.
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b => // Configures the relationships for IdentityUserLogin.
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b => // Configures the relationships for IdentityUserRole.
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b => // Configures the relationships for IdentityUserToken.
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("ProjektSklep.Models.Product", b => // Configures the relationships for Product.
            {
                b.HasOne("ProjektSklep.Models.Cart", null)
                    .WithMany("Products")
                    .HasForeignKey("CartId");
            });

            modelBuilder.Entity("ProjektSklep.Models.Cart", b => // Configures the navigation property for Cart.
            {
                b.Navigation("Products");
            });
#pragma warning restore 612, 618 // Re-enables warnings for obsolete API usage.
        }
    }
}
