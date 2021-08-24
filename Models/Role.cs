using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Is_my_life.Models
{
    public class Role
    {
        public class Dubber
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int DubberID { get; set; }
            public User User { get; set; }
            public Person Person { get; set; }
            public List<Anime> Animes { get; set; } = new List<Anime>(); //dubbed animes
        }
        public class Interpreter
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int InterpreterID { get; set; }
            public User User { get; set; }
            public Person Person { get; set; }
            public List<Anime> Animes { get; set; } = new List<Anime>(); //translated animes
            public List<Manga> Mangas { get; set; } = new List<Manga>(); //translated mangas
        }
        public class Mangaka //maybe should add something here
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int MangakaID { get; set; }
            public Person MangakaPerson { get; set; }
            public List<Manga> Mangas { get; set; } = new List<Manga>();

        }
        public class Producer
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ProducerID { get; set; }
            public string Name { get; set; }
            public DateTime Founded { get; set; }
            public List<Person> Founders { get; set; } = new List<Person>();
            public List<Person> Owner { get; set; } = new List<Person>();
            public int NumberofEmployees { get; set; }
            public string Industry { get; set; }
            public List<Genre> Genres = new List<Genre>();
        }
        public class Publisher
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int PublisherID { get; set; }
            public List<Person> Founders { get; set; } = new List<Person>();
            public string CompanyName { get; set; }
            public List<Manga> Mangas { get; set; } = new List<Manga>();
            public List<Anime> Animes { get; set; } = new List<Anime>();
            public List<Genre> Genres = new List<Genre>();

        }

    }
}
