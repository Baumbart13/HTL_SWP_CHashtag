using Microsoft.EntityFrameworkCore;

namespace ORM_Grundlagen.Models.Db {
    public class Context : DbContext{
        public DbSet<CoercivePower> CoercivePower { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<CompensationMeasure> Cm { get; set; }
        public DbSet<EventLog> EventLog { get; set; }
    }
}