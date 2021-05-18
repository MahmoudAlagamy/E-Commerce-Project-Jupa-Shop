using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.Models
{
    public class MobilesVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name Of Prand")]
        [MaxLength(50, ErrorMessage = "Max Len 50")]
        [MinLength(3, ErrorMessage = "Min Len 2")]
        public string Prand { get; set; }

        public string Details { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        [Range(1000, 100000, ErrorMessage = "Enter Price From 1K To 100K")]
        public double Price { get; set; }

        public double Descount { get; set; }

        // To Reseve File
        public IFormFile ImageUrl { get; set; }

        // Upload Files
        public string ImageName { get; set; }

    }
}
