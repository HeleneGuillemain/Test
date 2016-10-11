using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string NomCategorie { get; set; }

        public virtual ICollection<Produit> produits { get; set; }
    }
}