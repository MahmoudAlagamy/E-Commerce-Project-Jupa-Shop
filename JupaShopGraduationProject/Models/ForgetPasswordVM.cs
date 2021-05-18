using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JupaShopGraduationProject.Models
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Requierd Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
