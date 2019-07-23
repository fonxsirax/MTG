using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MTG.Data.Mapping;
using MTG.Models;
using System;

namespace MTG.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> options)
            : base(options) { }

        public DbSet<Card> cards { get; set; } //referencia da entidade


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuração do mapeamento da entidade
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CardMap());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("CardContext"));
        //}
    }
}
