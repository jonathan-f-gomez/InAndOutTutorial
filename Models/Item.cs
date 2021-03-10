﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InAndOutTutorial.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }

        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; }
        
    }
}
