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
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Genre")]
        [Required]
        public String Name { get; set; }
       
    }
}
