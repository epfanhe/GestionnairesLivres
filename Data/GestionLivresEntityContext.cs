using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnairesLivres.Data
{
    public class GestionLivresEntityContext : DbContext
    {
        public GestionLivresEntityContext(DbContextOptions<GestionLivresEntityContext> options)
            : base(options)
        {

        }


        public DbSet<Models.Livre> Livres
        {
            get; set;
        }
        public object Livre { get; internal set; }
    }
}
