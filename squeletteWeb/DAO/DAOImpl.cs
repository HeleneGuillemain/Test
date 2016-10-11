using squeletteWeb.Métier;
using squeletteWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace squeletteWeb.DAO
{
    public class DAOImpl: IDAO
    {
        public Produit AjouterProduit(Produit p)
        {
            using(var db = new DAO.ProduitContext())
            {
                db.produits.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public List<Produit> listerProduits()
        {
            using(var db = new DAO.ProduitContext())
            {
                return db.produits.ToList<Produit>();
            }
        }

        public Produit trouverProduit(int ProduitId)
        {
            using (var db = new DAO.ProduitContext())
            {
                return db.produits.Find(ProduitId);
            }
        }

        public void supprimerProduit(int ProduitId)
        {
            using (var db = new DAO.ProduitContext())
            {
                var objet = db.produits.Find(ProduitId);
                db.produits.Remove(objet);
                db.SaveChanges();
            }
        }

        public ICollection<Produit> findProduitsByName(string nom)
        {
            using (var db = new DAO.ProduitContext())
            {
                //return db.produits.Where(p => p.Nom.Contains("%"+nom+"%")).ToList();

                var req = from p in db.produits
                          where p.Nom.Contains(nom)
                          select p;
                return req.ToList();
            }
        }

        public Categorie AjouterCategorie(Categorie c)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.categories.Add(c);
                db.SaveChanges();
                return c;
            }
        }

        public Magasin AjouterMagasin(Magasin m)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.magasins.Add(m);
                db.SaveChanges();
                return m;
            }
        }

        public ICollection<Magasin> listerMagasins()
        {
            using (var db = new DAO.ProduitContext())
            {
                return db.magasins.ToList();
            }
        }

        public Magasin EditerMagasin(Magasin m)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
                return m;
            }
        }

        public Magasin trouverMagasin(int MagasinId)
        {
            using(var db = new DAO.ProduitContext())
            {
                return db.magasins.Find(MagasinId);
            }
        }

        public void DeleteMagasin (int MagasinId)
        {
            using(var db = new DAO.ProduitContext())
            {
                var objet = db.magasins.Find(MagasinId);
                db.magasins.Remove(objet);
                db.SaveChanges();
            }
        }

        public Produit Editer(Produit p)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                return p;
            }
        }

        public ICollection<Categorie> listerCategories()
        {
            using (var db = new DAO.ProduitContext())
            {
                return db.categories.ToList();
            }
        }

        public Categorie trouverCategorie(int CategorieId)
        {
            using (var db = new DAO.ProduitContext())
            {
                return db.categories.Find(CategorieId);
            }
        }

        public Categorie EditerCategorie(Categorie c)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return c;
            }
        }

        public void DeleteCategorie(int CategorieId)
        {
            using (var db = new DAO.ProduitContext())
            {
                var objet = db.categories.Find(CategorieId);
                db.categories.Remove(objet);
                db.SaveChanges();
            }
        }

        public Client AjouterClient(Client c)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.clients.Add(c);
                db.SaveChanges();
                return c;
            }
        }

        public ICollection<Client> listerClients()
        {
            using (var db = new DAO.ProduitContext())
            {
                return db.clients.ToList();
            }
        }

        public ICollection<ProduitCatModel> findAllProduitCategorie()
        {
            using (var db = new DAO.ProduitContext())
            {
                var req = from p in db.produits
                          join c in db.categories
                          on p.CategorieId equals c.CategorieId
                          select new ProduitCatModel
                          {
                              ProduitId = p.ProduitId,
                              Prix = p.Prix,
                              Nom = p.Nom,
                              Description = p.Description,
                              NomCategorie = c.NomCategorie
                          };
                return req.ToList();
            }
        }

        public Client loginUser(Client c)
        {
            using (var db = new DAO.ProduitContext())
            {
                var usr = db.clients.FirstOrDefault(u => u.login == c.login && u.MotDePasse == c.MotDePasse);
                return usr;


                /*
                 var usr = from u in db.clients
                           where u.login == c.login && u.MotDePasse == c.MotDePasse
                           select u;

                 return usr.FirstOrDefault();
                  */
            }
        }

        public MagasinProduit AjouterMagasinProduit(MagasinProduit mp)
        {
            using (var db = new DAO.ProduitContext())
            {
                db.magasinProduits.Add(mp);
                db.SaveChanges();
                return mp;
            }
        }

        public ICollection<MagasinProduitModel> listerMagasinProduit()
        {
            using (var db = new DAO.ProduitContext())
            {
                var res = from mp in db.magasinProduits
                          join p in db.produits on mp.ProduitId equals p.ProduitId
                          join m in db.magasins on mp.MagasinId equals m.MagasinId
                          select new MagasinProduitModel
                          {
                              Nom = p.Nom,
                              NomMagasin = m.NomMagasin,
                              stock = mp.stock
                          };

                return res.ToList();
            }
        }
    }
}