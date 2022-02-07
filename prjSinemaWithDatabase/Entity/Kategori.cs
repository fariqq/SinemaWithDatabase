using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSinemaWithDatabase.Entity
{
    public class Kategori
    {
        [Key] public int ID { get; set; }
        public string Ad { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
