using System;
using Inventario.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Context
{
    public class InventarioContext : DbContext
    {
        public InventarioContext()
        {
            
        }
        public InventarioContext(DbContextOptions<InventarioContext> Options) : base(Options) 
        {

        }
        
        #region Tablas
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlite("Data Source=InventarioDH.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder ModBuilder)
        {
            base.OnModelCreating(ModBuilder);

            // Productos
            ModBuilder.Entity<Producto>().
                HasKey(x => x.ID);
            ModBuilder.Entity<Producto>().
                Property(x => x.ID).
                ValueGeneratedOnAdd();
            ModBuilder.Entity<Producto>().
                HasOne(x => x.Categoria).
                WithMany(x => x.Productos).
                HasForeignKey(x => x.CategoriaID).
                OnDelete(DeleteBehavior.Restrict);
            ModBuilder.Entity<Producto>().
                HasOne(x => x.Proveedor).
                WithMany(x => x.Productos).
                HasForeignKey(x => x.ProveedorID).
                OnDelete(DeleteBehavior.Restrict);

            // Categorías
            ModBuilder.Entity<Categoria>().
                HasKey(x => x.ID);
            ModBuilder.Entity<Categoria>().
                Property(x => x.ID).
                ValueGeneratedOnAdd();

            // Proveedores
            ModBuilder.Entity<Proveedor>().
                HasKey(x => x.ID);
            ModBuilder.Entity<Proveedor>().
                Property(x => x.ID).
                ValueGeneratedOnAdd();
        }
    }
}