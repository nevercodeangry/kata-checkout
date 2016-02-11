using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckoutKata.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        [Display(Name ="Products")]
        public string Item { get; set; }
    }
}