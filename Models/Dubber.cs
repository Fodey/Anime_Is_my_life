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
        public List<User> User { get; set; } = new List<User>();
        public List<Person> Person { get; set; } = new List<Person>();
        public List<Anime> Animes { get; set; } = new List<Anime>();
        public List<Manga> Mangas { get; set; } = new List<Manga>();
    }
}
