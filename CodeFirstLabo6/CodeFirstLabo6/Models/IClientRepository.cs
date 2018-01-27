using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstLabo6.Models
{
   public interface IClientRepository
    {
        IEnumerable<Client> Clients();
    }
}
