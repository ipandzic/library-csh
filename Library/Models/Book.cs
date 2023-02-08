using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Book")]

        [Required]
        public String Name { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public String Position { get; set; }

        public int Pages { get; set; }

    }

}
       
