using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Example1
{
    public class SimplePerson
    {
        
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(20, ErrorMessage = "The name can't be more than 20 characters")]
        public string FirstName { get; set; }
        [Required]
        [Range(1,50, ErrorMessage = "Age must be between 1, 50")]
        public int Age { get; set; }
    }
}
