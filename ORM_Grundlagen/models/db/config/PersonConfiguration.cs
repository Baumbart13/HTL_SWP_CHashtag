using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORM_Grundlagen.models;

namespace ORM_Grundlagen.db.config
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("people");
            builder.HasKey(p => p.Id); // Primary Key
            builder.Property(p => p.Id).HasColumnName("person_id");
            builder.Property(p => p.FirstName).HasColumnName("firstname").HasMaxLength(100);
            builder.Property(p => p.LastName).HasColumnName("lastname").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Salary).HasColumnName("salary").IsRequired();
            builder.Property(p => p.Birthdate).HasColumnName("birthdate");
            builder.Property(p => p.Gender).HasColumnName("gender").IsRequired(true);
            builder.Property(p => p.Department).HasColumnName("department");
        }
    }
}