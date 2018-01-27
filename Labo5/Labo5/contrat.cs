using System;
using System.Collections.Generic;
using System.Text;

namespace Labo5
{
    class Contrat
    {
        public int numero{ get; private set; }
        public double montant { get; private set; }
        public int numeroEmploye { get; private set; }


        public Contrat()
        {
            this.numero = 0;
            this.montant = 0.0;
            this.numeroEmploye = 0;
        }
        public Contrat(int numero, double montant, int numeroEmploye)
        {
            this.numero = numero;
            this.montant = montant;
            this.numeroEmploye = numeroEmploye;
        }
    }
}
