using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_trang.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }
    }
}