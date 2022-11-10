﻿using ApiDotnetRobusta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("pessoa");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Idpessoa")
                .UseIdentityColumn();

            builder.Property(x => x.Document)
                .HasColumnName("Documento");

            builder.Property(x => x.Name)
               .HasColumnName("Nome");

            builder.Property(x => x.Phone)
               .HasColumnName("Celular");

            builder.HasMany(x => x.Purchases)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
