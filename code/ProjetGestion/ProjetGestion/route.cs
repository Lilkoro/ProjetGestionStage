using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion
{
    class route
    {
        public class Entreprise
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class API
        {
            public List<Entreprise> Entreprises { get; private set;} = new List<Entreprise>();
    }

    }
}
