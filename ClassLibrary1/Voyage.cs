using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
   class Voyage
   {
            public int Id { get; set; }
            public int DestinationId { get; set; }
            public DateTime DateAller { get; set; }
            public DateTime DateRetour { get; set; }
            public int NombreVoygeur { get; set; }
            public int[] CampagneIds { get; set; }

            public double PrixUnitaire { get; set; }
   }
   
}

