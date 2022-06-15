using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Prix { get; set; }
        public ICollection<Chambre> Chambres { get; set; }
    }
}
