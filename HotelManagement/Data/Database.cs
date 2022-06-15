using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Data
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql(
              "Host=localhost;Database=hotelManagement;Username=postgres;Password=root@123");

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

    }
}
