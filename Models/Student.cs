using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication16.Models
{
    public class Student
    {
        [Key]

        public int ID { set; get; }


        public string Name { set; get; }

        public string city { set; get; }

    }
}
