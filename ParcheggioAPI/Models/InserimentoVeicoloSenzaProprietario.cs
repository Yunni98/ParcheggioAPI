﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcheggioAPI.Models
{
    public class InserimentoVeicoloSenzaProprietario
    {
        public Vehicle Veicolo { get; set; }
        public ParkingStatuss TabellaInserimento { get; set; }
    }
}
