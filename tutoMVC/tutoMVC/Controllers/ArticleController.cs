using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace tutoMVC.Controllers
{
    public class ArticleController : Controller
    {
        //premire methode lire (int id, string tite) parametre obligatoire, 2eme methode lire(int id ) param optionnel

        /* public IActionResult lire(int id, string title)
         {
             ViewBag.ArticleId = id;
             ViewBag.ArticleTitle = title.Replace("-","");
             return View();
         }*/

            //2eme methode parametre optionnel
         public IActionResult lire(int id)
              {
            string title = (Request.QueryString).ToString();
                  ViewBag.ArticleId = id;
                 if(!string.IsNullOrEmpty(title))
                ViewBag.ArticleTitle = title.Replace("-","");
                  return View();
              }

    }

}