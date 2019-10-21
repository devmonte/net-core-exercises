using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _11_TagHelpers.Models
{
    public class ExampleViewModel
    {
        public string Name { get; set; }
        [Display(Name = "How old are  you?")]
        public int Age { get; set; }
        public DateTime Time { get; set; }
    }
}
