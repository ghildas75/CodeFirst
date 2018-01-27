using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    [Table("CATEGORIES")]
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }
        [StringLength(25)]
        [Required, MinLength(4)]
        public String  NomCategorie { get; set; }
        public ICollection<Produit> Produits { get; set; }
    }
}
