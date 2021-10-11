using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication16.Models
{
    public class Music
    {
        [Key]
        public int ID { get; set; }
        [Required]
      
      
        public string Title { set; get; }
        [Required]
        
        public string LongArticle { set; get; }

        public DateTime CreateDate { get; set; }
    }
}
