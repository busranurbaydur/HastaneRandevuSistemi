
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemiEntities
{
    [Table("Hastalar")]
    public class Hasta:Kisi
    {
        [Key]
        [Column(Order = 1)]
        public int HastaId { get; set; }

        [Required(ErrorMessage = "Lütfen Hasta Adı Giriniz!")]
        [StringLength(50)]
        [Display(Name = "Hasta Adı")]
        public string HastaAdi { get; set; }

        [Required(ErrorMessage = "Lütfen Hasta Adı Giriniz!")]
        [StringLength(50)]
        [Display(Name = "Hasta Soyadı")]
        public string HastaSoyadi { get; set; }

        public virtual List<Randevu> RandevuList { get; set; }

        public override string ToString()
        {
            return $"{this.TCNumarasi} {this.HastaAdi} {this.HastaSoyadi}";
        }

    }
}
