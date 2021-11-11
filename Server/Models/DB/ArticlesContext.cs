using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class ArticlesContext: DbContext
    {
        // Datenbanksatz zum Zugriff auf die Tabelle Articles der Datenbank
        public DbSet<Article> Articles { get; set; }
        //Verbindungszeichenkette für den Mysql-Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = "localhost";
            var database = "onlineshop_api_g1";
            var user = "root";
            var password = "DuArschloch4";
            optionsBuilder.UseMySQL($"Server={server};database={database};user={user};password={password}");
        }
    }
}
