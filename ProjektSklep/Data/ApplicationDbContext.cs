<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore; 
using ProjektSklep.Models; 

namespace ProjektSklep.Data; // Przestrzeń nazw dla danych projektu.

public class ApplicationDbContext : IdentityDbContext // Definicja kontekstu bazy danych, dziedziczącego z IdentityDbContext, co zapewnia integrację z tożsamościami użytkowników.
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) // Konstruktor kontekstu bazy danych przyjmujący opcje jako parametr.
        : base(options) // Wywołanie konstruktora bazowego z przekazanymi opcjami.
    {
    }

    public DbSet<Cart> Carts { get; set; } // Definicja DbSet dla koszyków, umożliwiająca pracę z tabelą Carts w bazie danych.
    public DbSet<Product> Products { get; set; } // Definicja DbSet dla produktów, umożliwiająca pracę z tabelą Products w bazie danych.
}
=======
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Models;

namespace ProjektSklep.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Product> Products { get; set; }
}
>>>>>>> 32d131835f28a01e93bea9a17374fbda08522876
