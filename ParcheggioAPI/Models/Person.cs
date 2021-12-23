﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ParcheggioAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            ParkingHistories = new HashSet<ParkingHistory>();
            Vehicles = new HashSet<Vehicle>();
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }

        public virtual ICollection<ParkingHistory> ParkingHistories { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
