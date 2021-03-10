using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOutTutorial.Models
{
    public class Expense
    {


        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1,double.MaxValue, ErrorMessage ="Amount must be greater than 0")]
        public double Amount { get; set; }
    }
}
