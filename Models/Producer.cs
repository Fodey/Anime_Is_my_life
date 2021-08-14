using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Producer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProducerID { get; set; }
        public string Name { get; set; }
        public DateTime Founded { get; set; }
        public string Founder { get; set; }
        public List<Person> Owner { get; set; } = new List<Person>();
        public int NumberofEmployees { get; set; }
        public string Industry { get; set; }
        //public Genre
    }
}
