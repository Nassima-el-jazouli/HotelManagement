using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public string Detail { get; set; }
        public Hotel Hotel { get; set; }
    }
}
