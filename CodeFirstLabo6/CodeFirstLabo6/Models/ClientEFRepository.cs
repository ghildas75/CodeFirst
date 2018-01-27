using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstLabo6.Models
{
    public class ClientEFRepository : IClientRepository
    {
        private Labo6Context _context;

        public ClientEFRepository(Labo6Context context)
        {
            _context = context;
        }

        public IEnumerable<Client> Clients()
        {
            return _context.Clients;
        }
    }
}
