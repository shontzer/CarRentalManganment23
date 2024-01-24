using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManganment23.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int year { get; set; }
        public string? LiscensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
        public int ColourId {  get; set; }
        public virtual Color? Colour { get; set; }
        public virtual List<Booking>? Bookings { get; set; }

    }
}
