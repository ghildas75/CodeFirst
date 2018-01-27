using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class ClientContext:DbContext
    {
        public DbSet<Client> Clients;

        public ClientContext(DbContextOptions Options):base (Options)
        {
        }

        public DbSet<WebApplication2.Models.Client> Client { get; set; }
    }
}
