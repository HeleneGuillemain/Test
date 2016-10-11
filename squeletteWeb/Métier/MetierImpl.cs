using squeletteWeb.DAO;
using squeletteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class MetierImpl :IMetier
    {

        public IDAO Idao = new DAOImpl();
        public Produit AjouterProduit(Produit p)
        {
            return Idao.AjouterProduit(p);
        }

        public List<Produit> listerProduits()
        {
            return Idao.listerProduits();
        }

        public void supprimerProduit(int ProduitId)
        {
            Idao.supprimerProduit(ProduitId);
        }

        public Produit trouverProduit(int ProduitId)
        {
            return Idao.trouverProduit(ProduitId);
        }

        public ICollection<Produit> findProduitsByName(string name)
        {
            return Idao.findProduitsByName(name).ToList();
        }

        public Categorie AjouterCategorie(Categorie c)
        {
            return Idao.AjouterCategorie(c);
        }

        public Magasin AjouterMagasin(Magasin m)
        {
            return Idao.AjouterMagasin(m);
        }

        public ICollection<Magasin> listerMagasins()
        {
            return Idao.listerMagasins();
        }

        public Magasin EditerMagasin(Magasin m)
        {
            return Idao.EditerMagasin(m);
        }

        public Magasin trouverMagasin(int MagasinId)
        {
            return Idao.trouverMagasin(MagasinId);
        }

        public void DeleteMagasin(int MagasinId)
        {
            Idao.DeleteMagasin(MagasinId);
        }

        public Produit Editer(Produit p)
        {
            return Idao.Editer(p);
        }

        public ICollection<Categorie> listerCategories()
        {
            return Idao.listerCategories();
        }

        public Categorie trouverCategorie(int CategorieId)
        {
            return Idao.trouverCategorie(CategorieId);
        }

        public Categorie EditerCategorie(Categorie c)
        {
            return Idao.EditerCategorie(c);
        }

        public void DeleteCategorie(int CategorieId)
        {
            Idao.DeleteCategorie(CategorieId);
        }

        public Client AjouterClient(Client c)
        {
            return Idao.AjouterClient(c);
        }


        public ICollection<Client> listerClients()
        {
            return Idao.listerClients();
        }

        public ICollection<ProduitCatModel> findAllProduitCategorie()
        {
            return Idao.findAllProduitCategorie();
        }

        public Client loginUser(Client c)
        {
            return Idao.loginUser(c);
        }

        public MagasinProduit AjouterMagasinProduit(MagasinProduit mp)
        {
            return Idao.AjouterMagasinProduit(mp);
        }

        public ICollection<MagasinProduitModel> listerMagasinProduit()
        {
            return Idao.listerMagasinProduit();
        }
    }
}