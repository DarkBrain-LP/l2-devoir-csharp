using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir
{
    internal class Client
    {
        //1
        public static int Id { get; set; } = 0;
        public String Nom { get; set; }
        public String Prenom { get; set; }

        //2
        public Client()
        {
            Id ++;
            ListClients.Add(this);
        }
        public Client(String nom, String prenom)
        {
            Id++;
            Nom = nom;
            Prenom = prenom;
            ListClients.Add(this);
        }

        //3
        public static List<Client> ListClients { get; private set; } = new List<Client>();


        //6
        public float TotalCommande()
        {
            float totalCommande = 0;

            foreach(Commande commande in Commande.ListCommandes)
            {
                if(commande.Client == this)
                {
                    totalCommande += commande.TotalCommande();
                }
            }

            return totalCommande;
        }

        // 9
        public override string ToString()
        {
            String affiche;
            affiche = "Client n° : " + Id + " : ";
            affiche += Nom + " ";
            affiche += Prenom + " ";
            affiche += "Total commandes : " + TotalCommande() + " F";

            return affiche;

        }
    }
}
