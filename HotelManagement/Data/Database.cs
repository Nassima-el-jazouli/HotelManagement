using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Tools;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Data
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql(
              "Host=localhost;Database=hotelManagement;Username=postgres;Password=root@123");
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyUtcDateTimeConverter();//Put before seed data and after model creation
        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Classement> Classements { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PrestationReservation> PrestationReservations { get; set; }
        public DbSet<ArchiveClient> ArchiveClients { get; set; }

        public DbSet<ArchiveReservation> ArchiveReservations { get; set; }
        public DbSet<ArchivePrestation> ArchivePrestations { get; set; }

    }
}
