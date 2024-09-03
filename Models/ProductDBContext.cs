using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using APICreation1.Model;

namespace productapi.Models
{
    public class productDBContext : DbContext
    {

        public productDBContext(DbContextOptions<productDBContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=productdb1;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}