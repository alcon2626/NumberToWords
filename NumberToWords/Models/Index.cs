using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumberToWords.Models
{
    public class Index
    {
        [Required]
        public double Amount { get; set; }
        public string AmountInWords { get; set; }
    }
}