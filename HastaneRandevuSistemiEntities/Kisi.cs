using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiEntities
{
    public abstract class Kisi
    {
        [Required(ErrorMessage = "Lütfen TC Kimlik Numarası Giriniz!")]
        [StringLength(11)]
        public string TCNumarasi { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        

    }
}
