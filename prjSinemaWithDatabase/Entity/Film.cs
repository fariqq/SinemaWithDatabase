using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSinemaWithDatabase.Entity
{
    public class Film
    {
        [Key] public int Id { get; set; }
        public string Ad { get; set; }
        public string FilmAciklama { get; set; }
        public int FilmUzunlugu { get; set; }
        public string ResimYolu { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")] public virtual Kategori Kategori { get; set; }
    }
}
