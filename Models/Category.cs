using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel;

namespace WebApplication16.Models
{
    public class Category
    {
        [Key]

        public int ID { set; get; }

        public string Name { set; get; }
    }
}
