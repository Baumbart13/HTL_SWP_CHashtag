using Microsoft.EntityFrameworkCore;
using ORM_Grundlagen.models;

namespace ORM_Grundlagen.db
{
    
    /// <summary>
    /// Die Context-Klasse ist der DB-Manager. Zugriff auf Tabellen, usw.
    /// </summary>
    public class OnlineshopContext : DbContext
    {
        /// <summary>
        /// Mit diesem Property haben wir Zugriff auf die DB-Tabelle People
        /// </summary>
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;database=onlineshop_orm_g1;user=root;password=DuArschloch4");
        }
    }
}