using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int Grade { get; set; }
        public string ReviewText { get; set; }
    }
}
