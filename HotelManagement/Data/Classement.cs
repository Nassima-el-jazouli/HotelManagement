using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class Classement
    {
        public int Id { get; set; }
        public float Note { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}
