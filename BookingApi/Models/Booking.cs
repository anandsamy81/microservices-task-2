using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime BookingTIme { get; set; }
        public string venue { get; set; }

        public string Screen { get; set; }
        public string MovieName { get; set; }

        public int NoofSeats { get; set; }

        public int Amount { get; set; }
    }
}
