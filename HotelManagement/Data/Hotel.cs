using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public string NumTel { get; set; }
        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }
        public int ClassementId { get; set; }
        public Classement Classement { get; set; }
        public ICollection<Chambre> Chambres { get; set; }
    }
}
