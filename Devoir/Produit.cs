using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir
{
    internal class Produit
    {
        //1
        public String Code { get; set; }
        public String Designation { get; set; }
        public float PrixUnitaire{ get; set; }
        public int QteStock { get; set; }

        //2
        public Produit()
        {
            ListProduits.Add(this);
        }
        public Produit(String code, String designation, float prixUnitaire, int qteStock)
        {
            if (prixUnitaire > 0)
            {
                Code = code;
                Designation = designation;
                PrixUnitaire = prixUnitaire;
                QteStock = qteStock;
                ListProduits.Add(this);
            }
            else
            {
                return;
            }
                
        }

        //3
        public static List<Produit> ListProduits { get; private set; } = new List<Produit>();

    }
}
