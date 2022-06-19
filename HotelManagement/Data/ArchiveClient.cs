using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class ArchiveClient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Cin { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
        public string NumTel { get; set; }
        public string Email { get; set; }
    }
}
