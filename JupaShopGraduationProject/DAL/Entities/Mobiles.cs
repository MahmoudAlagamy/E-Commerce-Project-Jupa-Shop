using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.DAL.Entities
{
    [Table("Mobiles")]
    public class Mobiles
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Prand { get; set; }

        [StringLength(255)]
        public string Details { get; set; }

        public double Price { get; set; }

        public double Descount { get; set; }

        public string ImageName { get; set; }

    }
}
