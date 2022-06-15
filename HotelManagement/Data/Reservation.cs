using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime DatePayeArrhes { get; set; }
        public float Arrhes { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ChambreId { get; set; }
        public Chambre Chambre { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Prestation> Prestations { get; set; }
    }
}
