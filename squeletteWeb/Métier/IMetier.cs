using squeletteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squeletteWeb.Métier
{
    public interface IMetier
    {
        Produit AjouterProduit(Produit p);
        List<Produit> listerProduits();
        void supprimerProduit(int ProduitId);
        Produit trouverProduit(int ProduitId);
        ICollection<Produit> findProduitsByName(string name);

        Categorie AjouterCategorie(Categorie c);
        Magasin AjouterMagasin(Magasin m);
        ICollection<Magasin> listerMagasins();
        Magasin EditerMagasin(Magasin m);
        Magasin trouverMagasin(int MagasinId);
        void DeleteMagasin(int MagasinId);

        Produit Editer(Produit p);
        ICollection<Categorie> listerCategories();
        Categorie trouverCategorie(int CategorieId);
        Categorie EditerCategorie(Categorie c);
        void DeleteCategorie(int CategorieId);

        Client AjouterClient(Client c);
        ICollection<Client> listerClients();

        ICollection<ProduitCatModel> findAllProduitCategorie();
        Client loginUser(Client c);
        MagasinProduit AjouterMagasinProduit(MagasinProduit mp);
        ICollection<MagasinProduitModel> listerMagasinProduit();
    }
}
