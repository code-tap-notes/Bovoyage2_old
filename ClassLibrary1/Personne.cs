using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    class Personne
    {
        
            public int Id { get; set; }
            public Civil Civilite { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Adresse { get; set; }
            public string Telephone { get; set; }
            public DateTime DateNaissance { get; set; }
            public int[] DossierVoyageIds { get; set; }
        public int GetAge()
            {
                return DateTime.Today.Year - DateNaissance.Year; ;
            }

    }
    enum Civil { Mr, Mme, Mlle }
}

