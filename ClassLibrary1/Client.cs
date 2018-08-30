using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.DAL
{
    class Client: Personne 
    {
        public int Id { get; set; }
        public string email { get; set; }
        public virtual Reservations reservation { get; set; }

    }
}
