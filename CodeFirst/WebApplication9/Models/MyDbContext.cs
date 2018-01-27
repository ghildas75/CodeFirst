using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class MyDbContext:DbContext
    {
        //declaration des objet qu'on veut gérer
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server= E5550-FC-05 ;Database=myData; Integrated Security=true;");
        }
    }
}
