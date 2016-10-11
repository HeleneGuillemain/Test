using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace squeletteWeb.Models
{
    public class MagasinProduitModel
    {
        [Display(Name="Magasin")]
        public string NomMagasin { get; set; }
        [Display(Name ="Produit")]
        public string Nom { get; set; }

        public int stock { get; set; }
    }
}