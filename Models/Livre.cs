using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Html;

namespace GestionnairesLivres.Models
{
    public class Livre
    {
        public int Id
        {
            get; set;
        }

        public string Titre
        {
            get; set;
        }

        public DateTime AnneePublication
        {
            get; set;
        }

        public string Auteur
        {
            get; set;
        }

        //public ICollection<Livres> livres { get; set; }
    }
}
