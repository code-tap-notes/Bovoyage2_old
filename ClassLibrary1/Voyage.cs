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
            public DateTime DateAller { get; set; }
            public DateTime DateRetour { get; set; }
            public int PlacesDisponible { get; set; }
            public double PrixParPersonne { get; set; }

            public void Reserver(int places)
            { this.Reserver()
             }
                       // [Foreingkey("IdDestination")]
            public virtual Destination destination{ get; set; }
                      //  [Foreingkey("IdDestination")]
            public virtual AgenceVoyage agenceVoyage { get; set; }

    }
   
}

