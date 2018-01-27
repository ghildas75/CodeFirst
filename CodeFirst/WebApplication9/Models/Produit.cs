using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    [Table ("Produit")]
    public class Produit
    {
        [Key]
        public int ProduitId { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(5)]
        public string  Designation { get; set; }
        public double  Prix { get; set; }
        public int CategorieID { get; set; }
        //propriete de navagation lasyLoading on va pas charger la categorie de la base de donne, navigation entre objet
        public virtual Categorie Categorie { get; set; }


    }
}
