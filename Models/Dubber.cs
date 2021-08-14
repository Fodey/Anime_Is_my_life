using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Dubber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DubberID { get; set; }
        public User User { get; set; }
        public Person Person { get; set; }
        public List<Anime> Animes { get; set; } = new List<Anime>(); //dubbed animes
        public List<Manga> Mangas { get; set; } = new List<Manga>(); //Can you dub a manga?
    }
}
