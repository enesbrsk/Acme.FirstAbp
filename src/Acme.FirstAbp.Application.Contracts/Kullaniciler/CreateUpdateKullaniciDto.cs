using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.FirstAbp.Kullaniciler
{
   public class CreateUpdateKullaniciDto 
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Surname { get; set; }

        [Required]
        public KullaniciType Type { get; set; } = KullaniciType.Undefined;


        [Required]
        public int Num { get; set; }
    }
}
