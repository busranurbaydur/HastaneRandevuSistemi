using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiEntities
{
    [Table("Doktorlar")]
    public class Doktor:Kisi,IMaasAlabilir
    {
       [Key]
       [Column(Order =1)] //1. sırada doktor ıd olsun istedik.
        public int DoktorId { get; set; }

        [Required(ErrorMessage ="Lütfen Doktor Adı Giriniz!")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="En Az 2 Karakterli Olmalıdır..")]
        [Display(Name ="Doktor Adı")] //böyle yazılsın istiyoruz..
        public string DoktorAdi { get; set; }

        [Required(ErrorMessage = "Lütfen Doktor Soyadı Giriniz!")]
        [StringLength(50)]
        [Display(Name = "Doktor Soyadı")]
        public string DoktorSoyadi { get; set; }

        [Display(Name = "Doktorun Branşı")]
        public Branslar Brans { get; set; }

        [Display(Name = "Maaş")]
        public decimal Maas { get ; set ; }

        public virtual List<Randevu> RandevuList { get; set; }
        public override string ToString()
        {
            return $"Dr. {this.DoktorAdi} {this.DoktorSoyadi}";
        }
    }
}
