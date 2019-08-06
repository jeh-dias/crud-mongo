using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Domain
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public long Age { get; set; }

        public string Breed { get; set; }
    }
}
