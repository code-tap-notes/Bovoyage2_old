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
            public int VoyageId { get; set; }
            public int AgeMin { get; set; }
            public int AgeMax { get; set; }
            public int NombreClientFavorable { get; set; }

            public List<int> ClientIds { get; set; }

            public void Telephoner(List<Client> Clients)
            {
                Console.Clear();
                Console.WriteLine("Liste des numéros de téléphone de clients à téléphoner :  ");
                foreach (var Client in Clients)
                {
                    Console.WriteLine(Client.Telephone);
                }

                Console.WriteLine("Le campagne a été effectué par téléphone avec succès ");
            }


        }
    
}
