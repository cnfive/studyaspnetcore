using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel;

namespace WebApplication16.Models
{
    [DisplayName("商品类别")]

     [DisplayColumn("Name")]
    public class Product
    {
        [Key]
        public int ID { set; get; }

        public string Name { set; get; }
        [DisplayName("输入类别名称：")]
        public  string Description { set; get; }

        public  virtual List<Category> Category { set; get; }
       
        public DateTime CreateDate { set; get; }

    }
}
