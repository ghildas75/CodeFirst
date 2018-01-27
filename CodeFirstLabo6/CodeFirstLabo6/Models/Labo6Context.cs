using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstLabo6.Models
{
    public class Labo6Context:DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public Labo6Context(DbContextOptions<Labo6Context> options):base(options)
        {
        }
    }
}
