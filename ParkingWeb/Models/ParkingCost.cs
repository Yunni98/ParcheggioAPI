using System;
using System.Collections.Generic;

#nullable disable

namespace ParkingWeb.Model
{
    public partial class ParkingCost
    {
        public ParkingCost()
        {
            ParkingHistories = new HashSet<ParkingHistory>();
        }

        public string TipoVeicolo { get; set; }
        public double Tariffa { get; set; }

        public virtual ICollection<ParkingHistory> ParkingHistories { get; set; }
    }
}
