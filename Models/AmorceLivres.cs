using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionnairesLivres.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnairesLivres.Models
{
    public static class AmorceLivres
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionLivresEntityContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionLivresEntityContext>>()))
            {
                // Look for any movies.
                if (context.Livres.Any())
                {
                    return;   // DB has been seeded
                }

                context.Livres.AddRange(
                    new Livre
                    {
                        Titre = "Le software au centre de Restigouche",
                        AnneePublication = DateTime.Parse("2022-2-12"),
                        Auteur = "Tremblay",
                    },

                    new Livre
                    {
                        Titre = "Un tour sur le framework ASP.NET Core MVC ",
                        AnneePublication = DateTime.Parse("2021-3-13"),
                        Auteur = "Boudreau",
                    },

                    new Livre
                    {
                        Titre = "Charp",
                        AnneePublication = DateTime.Parse("2020-2-23"),
                        Auteur = "Michel",
                    },

                    new Livre
                    {
                        Titre = "Le clonage des projets en .NET",
                        AnneePublication = DateTime.Parse("2020-4-15"),
                        Auteur = "Yassin",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
