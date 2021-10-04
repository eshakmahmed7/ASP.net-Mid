using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB Task Products.Models.Entity
{
    public class Student
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Please provide a name")]
        [MinLength(2,ErrorMessage ="Name Must be > then 2")]
        [MaxLength(10,ErrorMessage ="Name Must be < less then 20")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please give a price")]
        public float Price { get; set; }
        [Required(ErrorMessage ="Please provide Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please provide Description")]
        public string Description { get; set; }
    }
}