using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class MagasinProduit
    {
        [Key, Column(Order = 0)]
        public int MagasinId { get; set; }
        [Key, Column(Order = 1)]
        public int ProduitId { get; set; }
        public virtual Magasin magasin { get; set; }
        public virtual Produit produit { get; set; }

        public int stock { get; set; }

    }
}