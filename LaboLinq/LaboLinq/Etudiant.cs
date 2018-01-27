using System;
using System.Collections.Generic;
using System.Text;

namespace LaboLinq
{
   
    class Etudiant
    {
        public string nom { get; private set; }
        public int note{ get; private set; }

        public Etudiant(string nom, int note)
        {
            this.nom = nom;
            this.note = note;
        }
        public override string ToString()
        {
            return string.Format("nom:{0}, note:{1}", nom, note);
        }
    }
}
