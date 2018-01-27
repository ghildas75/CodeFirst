using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambdalabo
{
    class Program
    {
        private static List<Produit> lstProduits = new List<Produit>();
        private static List<Client> lstClients = new List<Client>();

        static void Main(string[] args)
        {
            // Remplissage des produits
            lstProduits.Add(new Produit(1, 10));
            lstProduits.Add(new Produit(2, 20));
            lstProduits.Add(new Produit(3, 30));
            lstProduits.Add(new Produit(4, 40));
            lstProduits.Add(new Produit(5, 50));
            lstProduits.Add(new Produit(6, 60));

            // Remplissage des clients
            Client unClient = new Client("Joseph", "Montréal", "Canada");
            unClient.ajouteCommande(new Commande(1, 3, false, Mois.Janvier, 1));
            unClient.ajouteCommande(new Commande(2, 5, true, Mois.Mai, 2));
            lstClients.Add(unClient);

            unClient = new Client("John", "Winnipeg", "Canada");
            unClient.ajouteCommande(new Commande(3, 10, false, Mois.Juillet, 1));
            unClient.ajouteCommande(new Commande(4, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("James", "Dallas", "USA");
            unClient.ajouteCommande(new Commande(5, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("Frank", "Seatle", "USA");
            unClient.ajouteCommande(new Commande(6, 20, false, Mois.Juillet, 5));
            lstClients.Add(unClient);
            /*     requete 1-------------------------------------------------
        --------------------------------------------------------------------- */
            Console.WriteLine("Les produit qui sont plus que 30 $");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            IEnumerable<Produit> req1=  from p in lstProduits
                       where p.prix > 30
                       select p;
            foreach (Produit p in req1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-----------------------------------");
            //2em methode
            Console.WriteLine("2 eme methode pour les produits supérieurs a 30");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            IEnumerable<Produit>  product=lstProduits.Where(p => p.prix > 30);
            foreach (Produit p in product)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
          /*            requete numero 2------------------------------------
           * ------------------------------------------- */
            Console.WriteLine("requete numero 2 moyenne et nombre de produit");
            
            double moyenneDePorduit = req1.Average(p => p.prix);
            int nombreProduit = req1.Count();

            Console.WriteLine(" nombre des poduit: {0} la moyenne: {1} ", nombreProduit, moyenneDePorduit);
           /* Console.WriteLine("!!!!!requete ajout de nouveau produit!!!");*/
            /*Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");*/

            lstProduits.Add(new Produit(7, 70));
            moyenneDePorduit = req1.Average(p => p.prix);
            nombreProduit = req1.Count();
            Console.WriteLine(" nombre des poduit: {0} la moyenne: {1} ", nombreProduit, moyenneDePorduit);

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            /* requete linq*****************************-------------      */
            Console.WriteLine("commandes passées par des clients amercains");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            IEnumerable<Commande> commandeUsa= lstClients.Where(c => c.pays == "USA").SelectMany(c => c.listeCommandes);
            foreach (var item in commandeUsa)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("2 eme methode pour client usa");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            var reqCommandeUSA = from c in lstClients
                                 where c.pays == "USA"
                                 select c.listeCommandes;

            foreach (var client in reqCommandeUSA)
            {
                foreach (var order in client)
                {
                    Console.WriteLine(order);
                }

            }
           
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Produits passés par  les clients canadiens");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            IEnumerable<Produit> productCa = from c in lstClients
                                where c.pays == "Canada"
                                from  cm in c.listeCommandes
                                from  p in lstProduits
                                where (cm.idproduit==p.produitID)
                                select p;

           IEnumerable<Commande> lstCm= lstClients.Where(c => c.pays == "Canada").SelectMany(c => c.listeCommandes);
           /*var prodca= lstCm.Join(lstProduits, c => c.idproduit, p =>p.produitID,(cmde,prod)=> new {
         product=prod
            });*/

            
            foreach (Produit p in productCa)
            {
                
                    Console.WriteLine("Produit Id:"+p.produitID+" Prix "+p.prix);
                

            }
            // requete le cout de commande pour chaque client
            Console.WriteLine("------------------------------");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("requete numero 3");
            var req = from cust in lstClients
                      from order in cust.listeCommandes
                      from pr in lstProduits
                      where pr.produitID == order.idproduit
                      select new
                      {
                          cust.nom,
                          order.quantite,
                          pr.prix
                      };


            foreach (var c in req)
            {
                var cout = (c.prix) * (c.quantite);
                Console.WriteLine("nom du client: " + c.nom + " cout total: " + cout);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("requete numero 4");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            var res = req.GroupBy(c => c.nom);

           // var somme = req.Sum(c => (c.quantite * c.prix));
            foreach (var h in res)
            {
                double ct = 0;
                Console.Write("Nom:" + h.Key);
                foreach (var c in h)
                {
                    ct = ct + (c.quantite) * (c.prix);
                    //Console.WriteLine(ct);
                }
                Console.WriteLine("\tMontant total: " + ct);
            }


            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
           Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("requete numero 5 ");
            Console.WriteLine("---------------------------");
            var req5 = from item in req
                       group item by item.nom into liste
                       select new { nom = liste.Key, montant = liste.Sum(rec => rec.prix * rec.quantite) };

            foreach (var e in req5)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("---------REQUETE 6");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            var req6 = from cust in lstClients
                       from cm in cust.listeCommandes
                       join prod in lstProduits on
                       cm.idproduit equals prod.produitID

                       select new
                       {
                           cust.nom,
                           cm.quantite,
                           prod.prix
                       };
            var res6 = req6.GroupBy(x => x.nom);

            foreach (var h in res6)
            {
                double ct = 0;
                Console.Write("Nom: " + h.Key);
                foreach (var c in h)
                {
                    ct = ct + (c.quantite) * (c.prix);
                    //Console.WriteLine(ct);
                }
                Console.WriteLine("\t Montant total: " + ct);
            }

            //requet 7
            //double max = req7.Max(c => c.montant);
            // Console.WriteLine("max cout" + max);
            // double maxyi = req7.Aggregate(int.MaxValue, (maxy, client) => (c.montant< min) ? unEtudiant.note : min);
            //Console.ReadKey();
            //double maximum = req.Aggregate(double.MinValue, (maxy, c) => (c.prix > maxy) ? c.prix : maxy);
            //Console.WriteLine("maximum avec agregate:"+ maximum);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("requete numero 7 avec agreagate");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            foreach (var h in res)
            {
                double bestOrder = 0;
                Console.Write("Nom: " + h.Key);
                foreach (var c in h)
                {
                    //double maxPrix= c.prix;
                    bestOrder = h.Aggregate(double.MinValue, (max, prod) => ((prod.prix)*(prod.quantite) > max) ? (prod.prix)*(prod.quantite) : max);
                   // Console.WriteLine(prix);
                }
                Console.WriteLine("\tCommande: "+bestOrder);
            }

            /*foreach (var h7 in req)
            {
               
                Console.WriteLine("Nom:" + h7.nom);
                
                
                
                    //double cout7= (c.quantite) *(c.prix);
                      //double cout7 = h7.Aggregate(maxy, c,y) => c.*y > maxy ? c*y : maxy);
                    Console.WriteLine(cout7);
                
                //Console.WriteLine("Montant total" + cout7);
            }*/
            // REQUETE NUMERO 8
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-------------Requete 8-----------------------------------------");
            var rq = from customer in lstClients
                     from cm in customer.listeCommandes
                     from proc in lstProduits
                     where cm.idproduit == proc.produitID
                    // group cm by proc.produitID
                     select new { proc.produitID, proc.prix,cm.quantite };
            var rs = rq.GroupBy(p => p.produitID);
            //double sommeDesNotesAvecAggregate = rs.Aggregate(0, (somme, p) => somme + p.K);
            Console.WriteLine("Produit"+"\t"+"cout total");
            foreach (var r in rs)
            {
                var tot = 0.0;
                Console.Write(r.Key+"\t");
                foreach (var item in r)
                {
                     tot = r.Aggregate(0.0, (somme,it) => somme + (it.prix)*(it.quantite));
                    //double tot = (item.quantite) * (item.prix);
                   // Console.WriteLine("total " + sommeDesNotesAvecAggregate);
                }
                Console.WriteLine(tot);
            }

            Console.ReadKey();
        }
    }
}