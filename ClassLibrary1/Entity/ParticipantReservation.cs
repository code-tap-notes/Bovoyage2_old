﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    class ParticipantReservation
    {
        public int Id { get; set; }
        //Pour FK  relation 9..*
        public virtual Participant participant { get; set; }
        public virtual DossierReservation dossierReservation { get; set; }
    }
}
