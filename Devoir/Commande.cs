using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir
{
    internal class Commande
    {
        //1
        public static int IdCommande { get; set; } = 0;
        public DateTime DateCommande { get; set; }
        public Client Client { get; set; }
        
        //2
        public Commande() 
        {
            ListCommandes.Add(this);
        }

        public Commande(DateTime dateCommande, Client client)
        {
            DateCommande = dateCommande;
            Client = client;
            ListCommandes.Add(this);
        }

        //3
        public static List<Commande> ListCommandes { get; private set; } = new List<Commande>();

        //5
        public float TotalCommande()
        {
            float total = 0;
            foreach (LigneCommande lc in LigneCommande.ListLigneCommandes)
            {
                if(lc.Commande == this)
                {
                    total += lc.totalLigneCommande();
                }
            }

            return total;
        }
    }
}
