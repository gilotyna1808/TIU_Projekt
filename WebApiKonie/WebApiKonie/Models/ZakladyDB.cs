using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class ZakladyDB:DbContext
    {
        public DbSet<Autoryzacja> Autoryzacja { get; set; }
        public DbSet<Klient>Klienci { get; set; }
        public DbSet<Kon> Konie { get; set; }
        public DbSet<Przebieg> Przebiegi { get; set; }
        public DbSet<SkladWyscigu> SkladWyscigow { get; set; }
        public DbSet<Wyscig> Wyscigi { get; set; }
        public DbSet<Zakład> Zaklady { get; set; }
        
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });
        
        protected ZakladyDB(DbContextOptions options) : base(options) { }

        public ZakladyDB(DbContextOptions<ZakladyDB> options): this((DbContextOptions)options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Politechnika\SEMESTR_VI\TIU\Projekt\GIT\WebApiKonie\WebApiKonie\Baza.mdf';Integrated Security=True;
                                          Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                          ApplicationIntent=ReadWrite;MultiSubnetFailover=False").UseLoggerFactory(loggerFactory);
            }
        }
    }
}
