using ApiDotnetRobusta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("Compra")
                .HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(p => p.ProductId)
                .HasColumnName("Idproduto"); 
            
            builder.Property(p => p.PersonID)
                .HasColumnName("Idpessoa");

            builder.Property(p => p.Date)
                .HasColumnName("Datacompra");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Purchases);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases);
            
                
        }
    }
}
