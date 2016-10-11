using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class Magasin
    {
        public int MagasinId { get; set; }
        public string NomMagasin { get; set; }

        ICollection<MagasinProduit> magasinProduits { get; set; }
    }
}