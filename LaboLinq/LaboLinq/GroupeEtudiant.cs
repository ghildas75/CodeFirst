using System;
using System.Collections.Generic;
using System.Text;

namespace LaboLinq
{
    class GroupeEtudiant
    {
        public  string nomGroupe { get; private set; }
        public List<Etudiant> lstEtudiant { get; private set; }

        public GroupeEtudiant(string nomGroupe)
        {
            lstEtudiant = new List<Etudiant>();
            this.nomGroupe = nomGroupe;
        }
        public void ajouterEtudiant(Etudiant unEtudiant)
        {
            lstEtudiant.Add(unEtudiant);
        }
        public override string ToString()
        {
            string chaine = string.Format("nom du groupe:{0}", nomGroupe);
            foreach (Etudiant e in lstEtudiant)
            {
                chaine += "\t" + e;
            }
            return chaine;
        }
    }
}
