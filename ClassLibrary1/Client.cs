﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    class Client: Personne 
    {
        public string email { get; set; }
        public int[] IdReservations { get; set; }

    }
}
