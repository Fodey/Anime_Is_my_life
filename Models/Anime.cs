using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Anime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AmountEpisodes { get; set; }
        public int Year { get; set; }
        public Role Publisher { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();


    }
}
