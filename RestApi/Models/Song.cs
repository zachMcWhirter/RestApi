using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Language { get; set; }
    }
}
