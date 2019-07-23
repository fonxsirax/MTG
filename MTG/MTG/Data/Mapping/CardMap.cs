using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Data.Mapping
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(t => t.id);
            builder.Property(t => t.name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t=> t.manaCost)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(t => t.CMC)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(t => t.colorIdentity)
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(t => t.typePermanent)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.superType)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.rarity)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(t => t.set)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(t => t.text)
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(t => t.artist)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.power)
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(t => t.toughness)
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(t => t.imgURL)
                .HasMaxLength(600)
                .IsRequired();

            builder.ToTable("Card");

        }
    }
}
