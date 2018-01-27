using System;
using System.Collections.Generic;
using System.Linq;


namespace LaboLinq
{
    class Program
    {
        private static List<GroupeEtudiant> lstGroupeEtudiants = new List<GroupeEtudiant>();
        static void Main(string[] args)
        {
          //3 étudiants dans le groupe LMB
            GroupeEtudiant groupeLMB = new GroupeEtudiant("LMB");
            groupeLMB.ajouterEtudiant(new Etudiant("Michel", 100));
            groupeLMB.ajouterEtudiant(new Etudiant("Jacques", 55));
            groupeLMB.ajouterEtudiant(new Etudiant("Roger", 55));

            // 3 étudiants dans le groupe FC
            GroupeEtudiant groupeFC = new GroupeEtudiant("FC");
            groupeFC.ajouterEtudiant(new Etudiant("Joachim", 87));
            groupeFC.ajouterEtudiant(new Etudiant("Carole", 78));
            groupeFC.ajouterEtudiant(new Etudiant("Josée", 58));

            // 2 étudiants dans le groupe HL
            GroupeEtudiant groupeHL = new GroupeEtudiant("HL");
            groupeHL.ajouterEtudiant(new Etudiant("Akim", 76));
            groupeHL.ajouterEtudiant(new Etudiant("Jim", 56));

            // Ajouter les 3 groupes dans la liste des groupes.
            lstGroupeEtudiants.Add(groupeLMB);
            lstGroupeEtudiants.Add(groupeFC);
            lstGroupeEtudiants.Add(groupeHL);
            //Console.WriteLine("Hello World!");

            //*Requêtes sur des ensembles hiérarchisés
            // Requête qui va chercher chaque étudiant dans chacun des groupes
            // Les from sont imbriqués
            var tousLesEtudiants = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiant // Pour ce groupe va chercher un étudiant
                                   select unEtudiant;
            Console.WriteLine("Exécution 1 de la requête");
            foreach (Etudiant unEtudiant in tousLesEtudiants)
                Console.WriteLine(unEtudiant);

            Console.WriteLine();
       Console.ReadKey();
            // Observation: La requête a déjà été créée
            groupeFC.ajouterEtudiant(new Etudiant("Le nerde", 100));

            Console.WriteLine("Exécution 2 de la même requête");
            foreach (var unEtudiant in tousLesEtudiants)
                Console.WriteLine(unEtudiant);
            Console.WriteLine("------note en bas de 60  et groupe contient L-------------------------");


            //* Requête sur des ensembles hiérarchisés
            // Requête qui récupère les étudiants qui sont en bas de 60 dans chacun des groupes dont le nom contient la lettre L

             var tousLesEtudiantsDesGroupesL = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                               where unGroupe.nomGroupe.Contains("L")
                                                    from unEtudiant in unGroupe.lstEtudiant // Pour ce groupe va chercher un étudiant
                                                    where unEtudiant.note < 60
                                               select new { unGroupe.nomGroupe, unEtudiant.nom, unEtudiant.note};  // Sélectionne-le


             foreach (var unEtudiant in tousLesEtudiantsDesGroupesL)
                 Console.WriteLine("Groupe: {0} --- Nom: {1}  Note: {2}", unEtudiant.nomGroupe, unEtudiant.nom, unEtudiant.note);
             Console.WriteLine("!!!!!!requete note  entre 55 et 60!!!!!!!!");

            //* Utilisation d'une requête à l'intérieur d'une autre requête
            // Faire passer tous les étudiants qui ont entre 55 et 60
            var etudiantsEntre55et60 = 
                           from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiant // Dans ce groupe va chercher un étudiant
                                   where unEtudiant.note >= 55 && unEtudiant.note < 60
                                   select unEtudiant;  // Sélectionne-le

            foreach (var unEtudiant in etudiantsEntre55et60)
                Console.WriteLine(unEtudiant);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //

            // Attention: La note est modifiée dans etudiantsEntre55et60Ont60 
            // mais pas dans etudiantsEntre55et60
            var etudiantsEntre55et60Ont60 = from unEtudiant in etudiantsEntre55et60
                                            select new { unEtudiant.nom, note = 60 };

            Console.WriteLine("Les anciennes notes:");
            foreach (var unEtudiant in etudiantsEntre55et60)
                Console.WriteLine("Nom de l'étudiant: {0} --- Note: {1}", unEtudiant.nom, unEtudiant.note);
            Console.WriteLine();

            Console.WriteLine("Les nouvelles notes:");
            foreach (var unEtudiant in etudiantsEntre55et60Ont60)
                Console.WriteLine("Nom de l'étudiant: {0} --- Note: {1}", unEtudiant.nom, unEtudiant.note);
            Console.WriteLine();
            Console.ReadKey();

            // Console.ReadKey();



            // Console.ReadKey();


        }
    }
}
