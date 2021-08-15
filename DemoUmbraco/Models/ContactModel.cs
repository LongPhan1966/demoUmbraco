using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoUmbraco.Models
{
    public class ContactModel
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Option { get; set; }
        [Required]
        public string Message { get; set; }
    }
}