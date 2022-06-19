using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class ArchivePrestation
    {
        public int Id { get; set; }
        public string Categorie { get; set; }
        public string SousCategorie { get; set; }
        public string Description { get; set; }
        public float Prix { get; set; }
    }
}
