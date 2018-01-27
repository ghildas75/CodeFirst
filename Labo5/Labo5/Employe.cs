using System;
using System.Collections.Generic;
using System.Text;

namespace Labo5
{
    class Employe
    {
        public int numero { get; private set; }
        public string prenom { get;  set; }
        public string nom{ get; private set; }
        public double salaire { get; private set; }


        public Employe()
        {
            this.numero = 0;
            this.prenom = string.Empty;
            this.nom = string.Empty;
            this.salaire = 0.00;

        }
        public Employe(int numero, string prenom, string nom, double salaire)
        {
            this.numero = numero;
            this.prenom = prenom;
            this.nom = nom;
            this.salaire = salaire;
        }
    }
}
