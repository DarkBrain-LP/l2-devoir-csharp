using System.Linq;

namespace Devoir
{
    public class Program
    {
        // Liste de clients
        static List<Client> clients = new()
        {
            new Client("DIALLO", "Issaka"),
            new Client("GALLO", "Irène")
        };

        // Liste des Produits
        static List<Produit> produits = new List<Produit>
        {
            new Produit("NES", "Nescagé", 650, 8),
            new Produit("VIVA500", "Vivalait 500g", 750, 5),
            new Produit("SUC", "Sucre en carreaux", 500, 15)
        };

        // Liste de Commandes
        static List<Commande> commandes = new List<Commande>
        {
            new Commande
            (
                new DateTime(2022, 02, 01),
                Client.ListClients.Where(Client => Client.Id == 1).First()
            ),
            new Commande
            (
                new DateTime(2022, 02, 02),
                Client.ListClients.Where(Client => Client.Id == 2).First()
            ),
            new Commande
            (
                new DateTime(2022, 02, 03),
                Client.ListClients.Where(Client => Client.Id == 1).First()
            ),
            new Commande
            (
                new DateTime(),
                Client.ListClients.Where(Client => Client.Id == 2).First()
            )
        };

        // Liste des Ligne Commandes
        static List<LigneCommande> ligneCommandes = new List<LigneCommande>
        {
            new LigneCommande
            (
                Commande.ListCommandes.Where(Commande => Commande.IdCommande == 1).First(),
                Produit.ListProduits.Where(Produit => Produit.Code == "NES").First(),
                3
            ),
            new LigneCommande
            (
                Commande.ListCommandes.Where(Commande => Commande.IdCommande == 1).First(),
                Produit.ListProduits.Where(Produit => Produit.Code == "SUC").First(),
                1
            ),
            new LigneCommande
            (
                Commande.ListCommandes.Where(Commande => Commande.IdCommande == 2).First(),
                Produit.ListProduits.Where(Produit => Produit.Code == "ID VIVA500").First(),
                4
            ),
            new LigneCommande
            (
                Commande.ListCommandes.Where(Commande => Commande.IdCommande == 3).First(),
                Produit.ListProduits.Where(Produit => Produit.Code == "SUC").First(),
                2
            )
        } ;


        static void Main(string[] args)
        {
            // Affichage des clients
            foreach (Client cl in clients)
            {
                cl.ToString();
            }

            // Total ligne commande de chaque ligne commande
            foreach(LigneCommande lc in ligneCommandes)
            {
                Console.WriteLine(lc.totalLigneCommande());
            }

            // Total des commandes de chaque client
            foreach(Commande commande in commandes)
            {
                Console.WriteLine(commande.TotalCommande());
            }


        }
    }
}
