using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication16.Models
{
    public class Article
    {
        [Key]
        public  int ID { get; set; }
        [Required]
        [DisplayName("标题")]
        [MaxLength(1,ErrorMessage ="至少一个汉字")]
        public  string  Title { set; get; }
        [Required]
        [MaxLength(1, ErrorMessage = "至少一个汉字")]
        public string LongArticle { set; get; }

        public  DateTime CreateDate { get; set; }

    }
}
