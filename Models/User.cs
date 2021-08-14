using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string Nickname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public DateTime dateofbirth { get; set; }
    }
}
