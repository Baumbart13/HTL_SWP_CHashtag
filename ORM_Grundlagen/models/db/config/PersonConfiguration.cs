using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORM_Grundlagen.models;

namespace ORM_Grundlagen.db.config
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id); // Primary Key
            builder.Property(p => p.Id).HasColumnName("person_id");
            
        }
    }
}