using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace prjSinemaWithDatabase.Entity
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public DbSet<Gorevli> Gorevlis { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
    }
}
