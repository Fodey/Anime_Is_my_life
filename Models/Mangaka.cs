using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Mangaka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MangakaID { get; set; }
        public List<Person> Mangakas = new List<Person>();
        public List<Manga> Mangas { get; set; } = new List<Manga>();

    }
}
