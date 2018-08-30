using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BoVoyage.DAL
    {
        class Participant:Personne
        {
            public int Id { get; set; } 
            public int NumeroUnique { get; set; }

            public bool Reductiont()
            {
            return (GetAge() < 12);
            }
    }
    
}
