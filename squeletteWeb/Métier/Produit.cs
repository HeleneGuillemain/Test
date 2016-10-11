using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class Produit
    {
        public int ProduitId { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Description { get; set; }

        public int CategorieId { get; set; }
        public virtual Categorie categorie { get; set; }

        ICollection<MagasinProduit> magasinProduits { get; set; }
    }
}