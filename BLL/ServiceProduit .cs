using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceProduit
    {
        private List<Produit> produits;

        public ServiceProduit()
        {
            produits = new List<Produit>();
        }

        private int GetNextId()
        {
            // Trouver le plus grand Id existant et ajouter 1
            if (produits.Count == 0)
            {
                return 1;
            }
            else
            {
                return produits.Max(p => p.Id) + 1;
            }
        }

        // Méthode Create
        public int Create(Produit nouveauProduit)
        {
            int nouvelId = GetNextId();
            nouveauProduit.Id = nouvelId;
            nouveauProduit.EstDispo = true;
            nouveauProduit.Référence = 4646+ nouvelId;
            nouveauProduit.Désignation = "Product6";
            nouveauProduit.Catégorie = "Jus";
            nouveauProduit.PrixHT = 44;
            produits.Add(nouveauProduit);
            return nouvelId;
        }

        // Méthode Read
        public Produit Read(int IdProduit)
        {
            Produit produit = produits.Find(p => p.Id == IdProduit);

            return produit;
        }

        // Méthode Update
        public bool Update(Produit produitModifie)
        {
            Produit produitExist = produits.Find(p => p.Id == produitModifie.Id);
            if (produitExist != null)
            {
                // Modifier les propriétés du produit existant
                produitExist.Référence = produitModifie.Référence;
                produitExist.EstDispo = produitModifie.EstDispo;
                produitExist.Désignation = produitModifie.Désignation;
                produitExist.PrixHT = produitModifie.PrixHT;
                produitExist.Catégorie = produitModifie.Catégorie;

                return true;
            }
            else
            {
                return false;
            }
        }
        // Méthode Remove
        public bool Remove(int idProduit)
        {
            Produit produitASupprimer = produits.Find(p => p.Id == idProduit);
            if (produitASupprimer != null)
            {
                produits.Remove(produitASupprimer);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Méthode All
        public List<Produit> All()
        {
            produits.Add(new Produit { Id = 1, Référence = 1001, EstDispo = true, 
                Désignation = "Product 1", PrixHT = 29.99, Catégorie = "Informatique" });

            produits.Add(new Produit { Id = 2, Référence = 1002, EstDispo = false, 
                Désignation = "Product 2", PrixHT = 49.99, Catégorie = "Bureautique" });

            produits.Add(new Produit { Id = 3, Référence = 1003, EstDispo = true, 
                Désignation = "Product 3", PrixHT = 19.99, Catégorie = "Informatique" });
          
            return produits;
        }
    }
}
