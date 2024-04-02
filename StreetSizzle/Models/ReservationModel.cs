using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreetSizzle.Models
{
    public class ReservationModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int TotalGuest { get; set; }
    }
}