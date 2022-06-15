using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Chambre
    {
        public int Id { get; set; }
        public string NumTel { get; set; }
        public float Prix { get; set; }
        public Boolean Reserved { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
