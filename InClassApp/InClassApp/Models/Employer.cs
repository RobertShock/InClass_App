using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InClassApp.Models
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyAddress { get; set; }
    }
}
