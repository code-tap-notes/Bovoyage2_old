using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
        class DossierVoyage
        {
            public int Id { get; set; }
            public EtatDossierReservation EtatDossier { get; set; }
            public string NumeroCarteBancaire { get; set; }
            public double prixParPersonne { get; set; }
            public int IdClient { get; set; }
            public int IdVoyage { get; set; }

            public double CaculerPrixTotal()
            {
                return 0d;
            }
        }

        enum EtatDossierReservation { enAttente, enCours, refuse, accepte }
        enum RaisonAnnulationDossier { parClient,placeInsuffisantes}
    
}
