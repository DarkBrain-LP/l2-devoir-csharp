using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir
{
    internal class LigneCommande
    {
        // 1
        public Commande Commande{ get; set; }
        public Produit Produit { get; set; }
        public int QteCommande { get; set; }

        //2
        public LigneCommande() 
        {
            ListLigneCommandes.Add(this);
        }

        public LigneCommande(Commande commande, Produit produit, int qteCommande)
        {
            Commande = commande;
            Produit = produit;
            QteCommande = qteCommande;
            ListLigneCommandes.Add(this);

            //7
            this.Produit.QteStock -= qteCommande;
        }

        //3
        public static List<LigneCommande> ListLigneCommandes { get; private set; } = new List<LigneCommande>();


        //4
        public float totalLigneCommande()
        {
            return this.Produit.PrixUnitaire * this.QteCommande;
        }
    }
}
