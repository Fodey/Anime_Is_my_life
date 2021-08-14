using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string GenreManga { get; set; }
        public string GenreShow { get; set; }
        public List<Anime> Animes { get; set; } = new List<Anime>();
        public List<Manga> Mangas { get; set; } = new List<Manga>();
    }
}
