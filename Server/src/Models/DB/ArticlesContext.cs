using Microsoft.EntityFrameworkCore;

namespace server.Models.DB
{
    public class ArticlesContext : DbContext
    {
        // Datenbanksatz zum Zugriff auf de Tabelle Articles der Datenbank
        public DbSet<Article> Articles { get; set; }

        // Verbindungszeichenkette für den MySQL-Server angeben
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = "localhost";
            var database = "web_api_g1";
            var user = "root";
            var password = "DuArschloch4";
            optionsBuilder.UseMySQL($"Server={server};database={database};user={user};password={password}");
        }
    }
}