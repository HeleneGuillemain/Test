using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace squeletteWeb.Métier
{
    public class Client
    {
        public int ClientId { get; set; }
        [Display(Name="Nom du Client")]
        [Required(ErrorMessage="Le champ NOM est obligatoire")]
        [MaxLength(15,ErrorMessage="Le Nom doit faire moins de 15 caractères")]
        public string Name { get; set; }
        [Display(Name="Prénom")]
        [Required(ErrorMessage="Le champ PRENOM est obligatoire")]
        [MaxLength(20,ErrorMessage="Le Prénom doit faire moins de 20 caractères")]
        [MinLength(5,ErrorMessage="Le Prénom doit faire plus de 5 caractères")]
        public string Surname { get; set; }
        [Display(Name="Salaire")]
        [Required(ErrorMessage = "Le champ SALAIRE est obligatoire")]
        public decimal Salary { get; set; }
        [Display(Name="Bonus")]
        [Required(ErrorMessage = "Le champ BONUS est obligatoire")]
        public int BonusPercent { get; set; }
        [Display(Name="Date de naissance")]
        [Required(ErrorMessage = "Le champ DATE DE NAISSANCE est obligatoire")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString="(0:yyyy-MM-dd)",ApplyFormatInEditMode=true)]
        [Range(typeof(DateTime),"1/1/1970","1/1/2010",ErrorMessage="Date Invalide")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name="Date de début")]
        [Required(ErrorMessage = "Le champ DATE DE DEBUT est obligatoire")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "(0:yyyy-MM-dd)", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }
        [Display(Name="Login")]
        [Required(ErrorMessage = "Le champ LOGIN est obligatoire")]
        public string login { get; set; }
        [Required(ErrorMessage = "Le champ MOT DE PASSE est obligatoire")]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
        [Required(ErrorMessage = "Le champ CONFIRMATION est obligatoire")]
        [Display(Name = "Confirmation du mot de passe")]
        [Compare("MotDePasse", ErrorMessage="Confirmez votre mot de passe")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmationMdP { get; set; }

    }
}