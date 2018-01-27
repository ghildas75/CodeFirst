using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication9.Controllers
{
    [Route("Catalogue")]
    public class CategorieController : Controller
    {
       
        public MyDbContext db { get; set; }
       public CategorieController(MyDbContext db)
        {
            this.db = db;
        }


        [Route("Categories")]
        public IActionResult ListeCategories()
        {
            IEnumerable<Categorie> cat = db.Categories.Include(c=>c.Produits);
            return View("ListCategories",cat);
        }
        [Route("Produits")]
        public IActionResult ProduitsParCat([FromForm (Name="CategoieID")]int CatID=-1)
        {
            IEnumerable<Categorie> categories = db.Categories;
            List<SelectListItem> items = new List<SelectListItem>();
            foreach(var c in categories)
            {
                items.Add(new SelectListItem
                {
                    Text = c.NomCategorie,
                    Value = c.CategorieID.ToString()
                });

            }
            Categorie cat;
            if (CatID == -1) cat = new Categorie() { Produits= new List<Produit>()};
            //Categorie cat = new Categorie();
            else
                cat = db.Categories.Include(c=>c.Produits).FirstOrDefault(c => c.CategorieID == CatID);
            ViewBag.listeCategories = items;
            return View("ProduitsParCat", cat);
        }
    }
}