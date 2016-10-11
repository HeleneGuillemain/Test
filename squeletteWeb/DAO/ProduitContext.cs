using squeletteWeb.Métier;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace squeletteWeb.DAO
{
    public class ProduitContext : DbContext
    {
        public DbSet<Produit> produits { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Magasin> magasins { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<MagasinProduit> magasinProduits { get; set; }

    }
}