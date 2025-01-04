using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Socialmedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.infraestructure.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Usuario");

            builder.Property(e => e.Id)
            .HasColumnName("IdUsuario");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.DateOfBirth)
            .HasColumnName("FechaNacimiento")
            .HasColumnType("date");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Telephone)
            .HasColumnName("Telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.IsActive)
            .HasColumnName("Activo")
            .ValueGeneratedNever();
        }
    }
}
