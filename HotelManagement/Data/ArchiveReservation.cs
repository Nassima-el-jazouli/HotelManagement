using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class ArchiveReservation
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime DatePayeArrhes { get; set; }
        public float Arrhes { get; set; }
    }
}
