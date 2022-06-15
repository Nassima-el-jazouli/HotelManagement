using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    [Table("Factures")]
    public class PrestationReservation
    {
        public int Id { get; set; }
        public DateTime DateFacture { get; set; }
        public Boolean Payed { get; set; }
        public float Total { get; set; }
        public int PrestationId { get; set; }
        public Prestation Prestation { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}
