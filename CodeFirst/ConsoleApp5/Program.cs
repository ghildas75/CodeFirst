using System;
using WebApplication9.Models;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new MyDbContext())
            {
                db.Database.EnsureDeleted();

                db.Database.EnsureCreated();
               Categorie c1= new Categorie { NomCategorie="Ordinateur"};
                Categorie c2 = new Categorie { NomCategorie = "Imprimante" };
                Categorie c3 = new Categorie { NomCategorie = "Souris" };
                db.Categories.Add(c1);
                db.Categories.Add(c2);
                db.Categories.Add(c3);
                db.Produits.Add( new Produit
                { Designation="note pad", Prix=6500, Categorie=c1
                });
                db.Produits.Add(new Produit
                {
                    Designation = "imprimante Laser",
                    Prix = 6500,
                    Categorie = c2
                });
                db.Produits.Add(new Produit
                {
                    Designation = "imprimante HP",
                    Prix = 6500,
                    Categorie = c2
                });
                db.SaveChanges();
            }
            Console.WriteLine("genration de la base de donnes");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
