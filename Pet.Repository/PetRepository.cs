
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Repository
{
    public class PetRepository : Repository<Pet>
    {
        public PetRepository(ILogger logger,string databaseName) : base(logger, databaseName)
        {
        }
    }
}
