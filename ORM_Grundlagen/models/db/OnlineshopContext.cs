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
        public DbSet<Article> Articles { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        
        // die folgenden drei DbSets sind nur wegen der n:m-Verknüpfung mit Zusatzfeld in der Zwischentabelle vorhanden
        public DbSet<Invoices2Articles2> Invoices2Articles2s { get; set; }
        public DbSet<Invoice2> Invoices2 { get; set; }
        public DbSet<Article2> Articles2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;database=onlineshop_orm_g1;user=root;password=DuArschloch4");
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
        }*/
    }
}