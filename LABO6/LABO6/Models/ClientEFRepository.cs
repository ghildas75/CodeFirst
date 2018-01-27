using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABO6.Models
{
  
    public class ClientEFRepository:IClientRepository
    {
        private MyContext _context;

        public ClientEFRepository(MyContext context)
        {
            _context = context;
        }
        public IEnumerable<Client> Clients()
        {
            return _context.clients;
        }
    }
}
