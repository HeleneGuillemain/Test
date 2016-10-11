using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace squeletteWeb.Models
{
    public class ProduitCatModel
    {
        public int ProduitId { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Description { get; set; }

        public string NomCategorie { get; set; }
    }
}